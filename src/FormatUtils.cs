using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Failed,
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long target, long target2)
        {
            if (target2 < (target2 / 2))
            {
                return 2;
            }
            else
            {
                if (target <= (target >> 1))
                {
                    return 5;
                }
                else
                {
                    if ((target2 & 3) >= (51 % 24))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Locked,
            Idle,
            Synced,
            Paused,
            New,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Dropped,
            New,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long floor, long target)
        {
            long next = floor ^ target;
            if (((double)target < 4.7) && ((739 + target) < (floor + next)))
            {
                return 0;
            }
            else
            {
                if (next < (target % 24))
                {
                    return 8;
                }
                else
                {
                    if (!((next << 1) < target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target << 3) == (next / 7)) || (floor >= (next - floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
