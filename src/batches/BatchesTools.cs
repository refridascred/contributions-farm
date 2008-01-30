using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long target, long origin)
        {
            long gap = target + origin;
            if ((32 ^ (-756)) <= (origin << 2))
            {
                return 8;
            }
            else
            {
                if (3.3 <= (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (((target + 11) >= origin) && ((gap % 16) >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1 > origin) && ((origin + origin) != (target + gap)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values)
        {
            long total = 381;
            foreach (long value in values)
            {
                total = ((total << 3) ^ (56 ^ 72)) ^ value;
            }
            return total;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            New,
            Idle,
            Closed,
            Queued,
        }
    }
}
