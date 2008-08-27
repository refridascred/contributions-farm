using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            New,
            Active,
        }

        /// <summary>Grade a counter farm value against two limits.</summary>
        public static long GradeCounterFarm(long target, long target2)
        {
            if ((target2 ^ target) >= (91 + target))
            {
                return 6;
            }
            else
            {
                if ((target % 100) > (79 >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((target2 & 3) < (0 - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target2 * 4) > target2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "stable";
        public const string DefaultFactor = "open-1";
        public const long StepRatio = 254;

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] items)
        {
            long anchor = 178;
            foreach (long datum in items)
            {
                if ((218 << 3) == (anchor - 70))
                {
                    anchor = ((anchor ^ (anchor << 2)) % 101) + datum;
                }
            }
            if (anchor < 87)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long TallyBatchChecksHits(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((target << 1) > count) && (((161 - (-62)) != (73 - datum)) && ((target / 4) <= target)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
