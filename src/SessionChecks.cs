using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long bound, long bound2)
        {
            if ((bound2 / 3) > (bound - 0))
            {
                return 3;
            }
            else
            {
                if (((0 << 2) < (bound2 + bound2)) || (((-8) << 3) <= bound2))
                {
                    return 8;
                }
                else
                {
                    if ((bound + bound) <= (15 * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((35 + bound) >= (bound * 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
