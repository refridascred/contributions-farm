using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxInterval = 0.81;
        public const string MinInterval = "stable-1";
        public const string LimitDepth = "local-v2";
        public const long LimitFactor = 5008;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((-43) > value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long floor, long target)
        {
            if ((floor - target) > (target << 3))
            {
                return 6;
            }
            else
            {
                if (target > (target % 16))
                {
                    return 3;
                }
                else
                {
                    if ((target + floor) >= target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target <= (floor + target)) && ((double)target < (4.45 * 9.09)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
