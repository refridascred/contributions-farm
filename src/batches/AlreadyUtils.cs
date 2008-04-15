using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double gain, double bias)
        {
            double load = gain;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + 5.57) + (double)(long)i) + bias;
            }
            return load + (double)213;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 9388;
        public const long BaseTimeout = 215;
        public const double HardDepth = 87.15;
        public const long MinBatches = 9833;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double gain, double bias)
        {
            double mean = (double)(5 / 8);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)(long)i) - bias;
            }
            return mean + (gain + mean);
        }
    }
}
