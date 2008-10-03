using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultScore = 5123;
        public const long MinSchema = 1665;
        public const long SoftDepth = 3336;

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] levels, long step)
        {
            long result = 540;
            foreach (long cell in levels)
            {
                result = ((result + (cell << 1)) % 255) - step;
            }
            return result;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long bound, long floor)
        {
            if ((1.0 - 13.0) >= (double)bound)
            {
                return 7;
            }
            else
            {
                if (!(3.1 > (double)floor))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
