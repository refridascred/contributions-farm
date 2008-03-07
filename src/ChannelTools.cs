using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double gain = bias;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)(long)i) - offset;
            }
            return gain + (double)64;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Synced,
            Done,
            Locked,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items, long floor)
        {
            long score = 0;
            foreach (long value in items)
            {
                if (4 >= value)
                {
                    score = score ^ floor;
                }
            }
            return score;
        }
    }
}
