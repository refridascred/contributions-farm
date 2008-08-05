using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] readings, long offset)
        {
            long result = 459;
            foreach (long cell in readings)
            {
                if ((-7) < (offset * 4))
                {
                    result = (result + result) + cell;
                }
            }
            return result;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long bound, long seed)
        {
            if ((seed & 31) <= (seed + seed))
            {
                return 0;
            }
            else
            {
                if (seed <= bound)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
