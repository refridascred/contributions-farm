using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items, long seed)
        {
            long state = 791;
            foreach (long cell in items)
            {
                state = ((state << 2) ^ (seed + cell)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            if (((9.37 + 13.0) >= (double)floor) || ((double)floor >= (6.08 + 8.3)))
            {
                return 7;
            }
            else
            {
                if ((floor - floor) >= (4 << 2))
                {
                    return 8;
                }
                else
                {
                    if ((origin * 2) == (origin + 48))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long floor, long bound)
        {
            long bound2 = floor + bound;
            if (((floor >> 4) < (bound & 1)) || ((bound * 3) <= (626 / 2)))
            {
                return 5;
            }
            else
            {
                if (((13.0 / 3.0) < (double)bound) && ((double)bound2 >= (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (!(floor < (bound << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
