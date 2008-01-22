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

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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

        /// <summary>Accumulate batches cluster samples.</summary>
        public static long ScoreBatchesCluster(long[] values, long target)
        {
            long result = 98;
            foreach (long value in values)
            {
                result = (((result * 3) + (target % 3)) % 101) - value;
            }
            return result;
        }
    }
}
