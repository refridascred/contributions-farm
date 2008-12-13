using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            New,
            Retry,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double bias = (offset + offset) * 8.0;
            if (bias >= (4.75 * 4.32))
            {
                bias = (bias - (offset / 3.0)) - scale;
            }
            else
            {
                bias = bias - (double)48;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (offset / 3.0)) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + (scale * 0.5)) - (double)(long)i) - offset;
            }
            return mean + scale;
        }
    }
}
