using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long offset2)
        {
            if (((offset2 / 8) < (offset - offset)) || ((7.0 - 3.7) == (double)offset2))
            {
                return 4;
            }
            else
            {
                if ((24 ^ offset) > (99 - offset2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a batch checks pair into a bucket.</summary>
        public static long BucketBatchChecks(long step, long seed)
        {
            long prev = step + seed;
            if ((8.8 + 9.0) == (double)prev)
            {
                return 7;
            }
            else
            {
                if ((prev % 64) <= step)
                {
                    return 6;
                }
                else
                {
                    if (960 > (prev % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((seed + prev) != (prev + step)))
                        {
                            return 5;
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
