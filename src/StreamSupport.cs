using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((0.18 * 5.06) < (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double offset)
        {
            double weight = (double)(305 - 31);
            if (weight < (double)50)
            {
                weight = (weight - (rate - weight)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)433) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
