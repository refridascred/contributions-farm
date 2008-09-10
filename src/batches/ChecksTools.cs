using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long target, long step)
        {
            if (((step % 60) >= (step - step)) && ((target + target) != (target * 2)))
            {
                return 5;
            }
            else
            {
                if (((step * 3) >= (step ^ step)) && ((0.1 + 7.0) >= (double)step))
                {
                    return 8;
                }
                else
                {
                    if (((step * 3) != (step ^ step)) && ((double)target > (double)8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - target) < (step >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Count { get; set; }
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
