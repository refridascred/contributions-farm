using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two queue schema measurements.</summary>
        public static double SmoothQueueSchema(double ratio, double span)
        {
            double gain = (double)(-856);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + span;
            }
            return gain - (ratio * 4.9);
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
