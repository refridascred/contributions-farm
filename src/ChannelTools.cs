using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value < 17.0)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double weight, double bias)
        {
            double drift = bias;
            if (drift > (drift + bias))
            {
                drift = drift - (weight * 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift + (double)76;
        }
    }
}
