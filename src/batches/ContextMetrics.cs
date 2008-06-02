using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double weight = offset - (offset * 1.85);
            if (weight < bias)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + bias;
            }
            return weight + (weight * 5.7);
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) < (count + cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double rate = bias2;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias2) - (double)(long)i;
            }
            return rate - (bias2 - bias);
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 3265;
        public const double BaseCluster = 24.67;
        public const long SoftDepth = 8723;
        public const double MinWidth = 48.82;
    }
}
