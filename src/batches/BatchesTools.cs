using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double scale, double span)
        {
            double drift = (scale + 4.1) * 7.4;
            if (drift >= scale)
            {
                drift = drift - 5.0;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift + span)) - (double)(long)i;
            }
            return drift - (scale - 17.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheBudget = 3523;
        public const long SoftCluster = 8346;
        public const string WindowWidth = "alpha-edge";
        public const long RetryBudget = 6529;
        public const long HardCluster = 9981;

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
