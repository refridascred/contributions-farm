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

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double bias, double offset)
        {
            double bias2 = 4.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (offset / 3.0)) + (double)(long)i;
            }
            return bias2 + bias;
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
