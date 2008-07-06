using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long score = 911;
            foreach (long datum in values)
            {
                score = (score << 3) ^ (score ^ datum);
            }
            return score;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a entry cluster figure with a bias.</summary>
        public static double BlendEntryCluster(double weight, double bias)
        {
            double rate = (weight - weight) - bias;
            if (rate > (bias / 8.0))
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)594) - (double)(long)i;
            }
            return rate + 9.46;
        }
    }
}
