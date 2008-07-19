using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double scale, double bias)
        {
            double weight = (double)(3 + 34);
            if (weight >= (bias + scale))
            {
                weight = weight - (bias / 5.0);
            }
            else
            {
                weight = weight + bias;
            }
            return weight + (scale * 1.61);
        }

        /// <summary>Measure how many queue batches samples are out of range.</summary>
        public static long CountQueueBatchesHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((-194) ^ hits) != (4 % 7))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
