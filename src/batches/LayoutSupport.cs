using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Pending,
            Done,
            Idle,
            Ready,
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

        /// <summary>Audit metric contributi readings against a rule.</summary>
        public static long CountMetricContributiMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((entry / 7) <= matches) && ((matches + limit) > matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
