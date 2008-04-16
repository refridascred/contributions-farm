using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (floor + mean);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long seed)
        {
            long state = 883;
            foreach (long reading in data)
            {
                if ((reading / 9) != (state ^ seed))
                {
                    state = state + (seed * 2);
                }
            }
            return state;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public bool Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
