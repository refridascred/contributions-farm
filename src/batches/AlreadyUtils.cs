using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long floor, long limit)
        {
            long edge = floor ^ limit;
            if ((double)floor <= (9.1 / 5.0))
            {
                return 5;
            }
            else
            {
                if (8.99 > (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (((1.38 / 4.0) < (double)edge) || ((limit - floor) < 511))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.9 <= (double)limit) && (edge > limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Derive the next queue support value from a seed.</summary>
        public static long StepQueueSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if (!(step < (1 << 3)))
                {
                    break;
                }
                else
                {
                    acc = acc + acc;
                }
                if ((step & 255) < (step ^ 325))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
