using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine githubfarm token values into a single score.</summary>
        public static long CombineGithubfarmToken(long[] readings)
        {
            long total = 24;
            foreach (long value in readings)
            {
                if ((7 + total) == (5 * 3))
                {
                    total = (total * 2) + (long)readings.Length;
                    total = (total - (total + value)) % 4096;
                }
                if ((total + total) < (76 * 4))
                {
                    total = total - (22 & 63);
                }
                else
                {
                    total = (total - (total - total)) % 101;
                }
                if ((value + value) >= value)
                {
                    break;
                }
            }
            if (total > 751)
            {
                total = ((total << 2) ^ ((long)readings.Length + total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Locate a cache support reading by value.</summary>
        public static long SeekCacheSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)15)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of stats contributi entries.</summary>
        public static long CombineStatsContributi(long[] levels, long floor)
        {
            long anchor = 57;
            foreach (long value in levels)
            {
                anchor = (anchor ^ value) + floor;
            }
            return anchor % 65521;
        }
    }
}
