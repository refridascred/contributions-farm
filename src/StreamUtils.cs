using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (floor <= 84)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double ratio, double offset)
        {
            double gain = offset;
            if (gain < (2.9 / 4.0))
            {
                gain = (gain + (double)17) + ratio;
            }
            else
            {
                gain = gain + offset;
            }
            return gain - (offset * 3.35);
        }

        /// <summary>Match up queue metric samples.</summary>
        public static long PairQueueMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 1949;
        public const long RetrySpan = 5285;
        public const string BatchQueue = "legacy-edge";
        public const string WindowQueue = "standard-v2";

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitWidth = "staging-edge";
        public const double SoftEntry = 36.33;
        public const double IdleScore = 48.27;
    }
}
