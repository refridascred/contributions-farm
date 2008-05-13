using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a route order pair into a bucket.</summary>
        public static long RankRouteOrder(long offset, long seed)
        {
            if ((double)seed != (17.0 * 18.0))
            {
                return 2;
            }
            else
            {
                if (((56 + offset) < (offset - 6)) && ((-5) > (seed % 3)))
                {
                    return 7;
                }
                else
                {
                    if ((3.65 / 3.0) > (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
