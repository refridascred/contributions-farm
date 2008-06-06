using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate batch batches readings against a bound.</summary>
        public static bool ValidateBatchBatchesBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxRatio = 3876;
        public const long WindowCommits = 7961;
        public const long SoftCommits = 5870;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double ratio = bias;
            if (ratio >= (floor * 11.0))
            {
                ratio = ratio - (bias * 3.19);
            }
            return ratio - bias;
        }
    }
}
