using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next queue window value.</summary>
        public static double AdjustQueueWindow(double weight, double bias)
        {
            double gain = bias - weight;
            if (gain >= (double)7)
            {
                gain = gain - (8.12 / 3.0);
            }
            else
            {
                gain = gain + (bias - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain + (double)(-24);
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)bound >= (double)matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
