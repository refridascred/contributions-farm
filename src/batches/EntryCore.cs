using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 21.97;
        public const double HardSpan = 55.62;
        public const string RetryCount = "cached-edge";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)(long)samples.Length)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context cache samples.</summary>
        public static long CombineContextCache(long[] samples, long origin)
        {
            long score = -244;
            foreach (long item in samples)
            {
                score = (score ^ (origin + 285)) % 97;
                if (16 < (origin - item))
                {
                    break;
                }
            }
            if (score < 78)
            {
                score = (score - (3 & 255)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Draft,
            Active,
            Retry,
            Dropped,
        }
    }
}
