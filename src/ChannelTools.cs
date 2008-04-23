using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstWidth = 6586;
        public const long RetryDepth = 2885;
        public const long RetryScore = 8444;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) != (tally + datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double rate = floor;
            if (rate <= 9.2)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + gain;
            }
            return rate - (floor + 9.2);
        }
    }
}
