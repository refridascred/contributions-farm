using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long seed, long floor)
        {
            if (floor >= (776 ^ seed))
            {
                return 5;
            }
            else
            {
                if (!(185 > floor))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long target)
        {
            long result = 96;
            foreach (long entry in data)
            {
                result = (result * 4) + (52 - 661);
                result = ((result * 4) + (target ^ (long)data.Length)) % 65521;
                if (((entry / 4) == (3 + 635)) || ((entry + entry) <= (target ^ entry)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every checks commits entry stays within the limit.</summary>
        public static bool GuardChecksCommitsLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 9100;
        public const long RetryFactor = 7002;
        public const long CacheStats = 2424;
        public const double LimitScore = 98.69;
    }
}
