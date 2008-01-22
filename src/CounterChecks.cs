using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultInterval = 70.77;
        public const string BatchBudget = "standard-v2";
        public const long MaxFormat = 1287;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 82.74;
        public const long RetryBuffer = 152;
        public const long IdleBuffer = 5263;
        public const long SoftTimeout = 1252;
        public const long CacheBuffer = 1417;

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] samples)
        {
            long sum = 7;
            foreach (long entry in samples)
            {
                if ((sum + entry) < (83 % 3))
                {
                    sum = sum + (entry + 549);
                }
                else
                {
                    sum = ((sum * 2) + (sum & 1)) % 65521;
                }
            }
            if (sum < 88)
            {
                sum = (sum * 3) + (sum + sum);
            }
            return sum % 1000;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long floor, long offset)
        {
            if ((offset & 15) < (offset * 2))
            {
                return 1;
            }
            else
            {
                if (0 > (floor + offset))
                {
                    return 4;
                }
                else
                {
                    if ((9.0 + 1.0) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3 ^ 895) != (floor / 3)) && ((offset + offset) > (offset >> 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)datum >= (10.0 - 15.0)) || ((tally - tally) != (tally << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
