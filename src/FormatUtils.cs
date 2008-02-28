using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank counter metrics input into a small class.</summary>
        public static long SortCounterMetrics(long step, long limit)
        {
            long slot = step ^ limit;
            if ((limit % 8) < slot)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) == (limit >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((slot * 3) >= (slot << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long seed)
        {
            if ((double)origin >= 3.71)
            {
                return 2;
            }
            else
            {
                if (origin >= 63)
                {
                    return 4;
                }
                else
                {
                    if ((origin <= seed) && ((origin >> 4) != (848 << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (712 < (seed + 622))
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
        }

        /// <summary>Iterate the queue farm series from a seed.</summary>
        public static long SeriesQueueFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count << 3) == (46 + count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
