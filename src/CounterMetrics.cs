using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long seed, long step)
        {
            long next = seed - step;
            if (((double)step <= (double)6) && ((next / 6) != (next + 17)))
            {
                return 8;
            }
            else
            {
                if ((double)step < (3.4 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if ((seed << 2) >= (103 ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first token payload entry that matches the target.</summary>
        public static long LookupTokenPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long origin, long bound)
        {
            long next = origin ^ bound;
            if ((bound <= (origin >> 1)) || ((4.0 - 20.0) == (double)origin))
            {
                return 5;
            }
            else
            {
                if ((double)next == (double)8)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
