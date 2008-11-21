using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double gain, double offset)
        {
            double drift = 7.94;
            if (drift <= offset)
            {
                drift = (drift - 18.0) - gain;
            }
            return drift - offset;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long limit, long bound)
        {
            if (2 <= (limit << 3))
            {
                return 7;
            }
            else
            {
                if ((9 * 2) < (bound ^ bound))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
