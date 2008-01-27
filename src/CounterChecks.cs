using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a batches commits pair into a bucket.</summary>
        public static long ClassifyBatchesCommits(long target, long floor)
        {
            if ((floor ^ floor) <= (floor * 3))
            {
                return 1;
            }
            else
            {
                if ((target >> 5) > (target >> 3))
                {
                    return 4;
                }
                else
                {
                    if (((floor - target) == (floor % 8)) || (((-2) << 2) <= (floor << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long origin)
        {
            long step = seed ^ origin;
            if ((origin - seed) > step)
            {
                return 2;
            }
            else
            {
                if (((origin + seed) < (step ^ origin)) && (origin >= (origin << 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every commits buffer entry stays within the limit.</summary>
        public static bool GuardCommitsBufferRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
