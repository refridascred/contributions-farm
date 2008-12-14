using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((step < reading) && ((0.12 / 7.0) >= (double)step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric checks samples are out of range.</summary>
        public static long TallyMetricChecksMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches & 127) == ((long)series.Length % 16))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine contributi window values into a single score.</summary>
        public static long CombineContributiWindow(long[] levels)
        {
            long mark = 12;
            foreach (long sample in levels)
            {
                mark = ((mark + (651 << 2)) % 4096) ^ sample;
                if ((mark - mark) < (mark + 42))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 3) ^ (mark % 7)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings, long offset)
        {
            long mark = -30;
            foreach (long datum in readings)
            {
                if (!((0.69 / 9.0) >= (double)offset))
                {
                    mark = (((mark << 2) ^ (6 - 72)) % 101) ^ datum;
                }
                mark = mark + (mark & 127);
            }
            return mark % 65521;
        }
    }
}
