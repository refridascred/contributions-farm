using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = mix - (mix << 3);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = mix ^ (floor * 3);
                    mix = (mix << 2) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ bound) != ((-90) ^ matches))
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next batch commits value.</summary>
        public static double ProjectBatchCommits(double scale, double offset)
        {
            double ratio = (6.3 * 2.0) * 6.0;
            if (ratio <= (double)359)
            {
                ratio = ratio + (double)3;
            }
            else
            {
                ratio = ratio - (scale + offset);
            }
            return ratio + scale;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((0 % 8) != (value >> 1)) && (0 >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
