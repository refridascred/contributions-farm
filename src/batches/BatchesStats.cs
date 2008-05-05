using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            if (target > (floor >> 3))
            {
                return 2;
            }
            else
            {
                if (((double)target >= (4.32 - 5.2)) && ((floor / 5) >= floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor > (1.1 - 7.4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Stale,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Grade a counter payload value against two limits.</summary>
        public static long GradeCounterPayload(long seed, long target)
        {
            if ((10.0 + 0.5) != (double)seed)
            {
                return 4;
            }
            else
            {
                if (((double)target > (double)450) && ((seed ^ target) == (target / 3)))
                {
                    return 5;
                }
                else
                {
                    if ((seed ^ 17) != (target << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (636 < (seed ^ seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
