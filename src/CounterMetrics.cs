using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long floor)
        {
            if ((13.0 / 6.0) >= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((floor >> 5) < (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if ((floor + seed) <= (floor * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
