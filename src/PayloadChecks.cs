using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count > (limit ^ 3))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Check that every queue schema entry stays within the limit.</summary>
        public static bool ValidateQueueSchemaLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            Failed,
            Stale,
            Paused,
            Retry,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits <= (reading + hits))
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 51.39;
        public const long MaxCluster = 6812;
        public const string SoftCluster = "strict-edge";
        public const long SoftInterval = 3606;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
