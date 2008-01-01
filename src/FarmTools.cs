using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a already report reading by value.</summary>
        public static long SeekAlreadyReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long limit)
        {
            if (limit <= (limit & 127))
            {
                return 2;
            }
            else
            {
                if (floor >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit & 3) <= ((-929) / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
