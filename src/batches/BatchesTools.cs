using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Retry,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double gain, double span)
        {
            double weight = (double)7 + 3.4;
            if (weight > (span / 4.0))
            {
                weight = (weight - span) - gain;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (double)75;
        }
    }
}
