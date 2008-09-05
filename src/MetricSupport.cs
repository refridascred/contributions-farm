using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long bound, long floor)
        {
            long gap = bound + floor;
            if ((floor + floor) <= bound)
            {
                return 2;
            }
            else
            {
                if (!((floor * 5) >= (bound * 5)))
                {
                    return 8;
                }
                else
                {
                    if ((1 - gap) >= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
