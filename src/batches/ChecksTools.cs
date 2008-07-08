using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long sum = 4;
            foreach (long datum in levels)
            {
                sum = (sum - datum) % 255;
            }
            if (sum < 28)
            {
                sum = (sum * 4) + (sum + sum);
            }
            return sum % 1000;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double bias)
        {
            double drift = weight;
            if (drift >= (drift + 6.86))
            {
                drift = (drift - drift) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (3.71 * 3.47)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Idle,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Measure how many graph window samples are out of range.</summary>
        public static long CountGraphWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches <= (69 * 4)) && (matches < (5 ^ matches)))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }
    }
}
