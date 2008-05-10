using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two batch editor measurements.</summary>
        public static double AdjustBatchEditor(double scale, double offset)
        {
            double gain = (double)(657 + 376);
            if (gain >= offset)
            {
                gain = (gain - offset) + scale;
            }
            else
            {
                gain = gain - (double)50;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (offset - offset)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Done,
            Dropped,
            Ready,
            Draft,
        }
    }
}
