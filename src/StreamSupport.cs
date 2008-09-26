using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double mean = 7.2;
            if (mean < (offset - mean))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + (20.0 + mean);
            }
            return mean - offset;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long step)
        {
            if (step >= origin)
            {
                return 3;
            }
            else
            {
                if ((step + step) <= (step >> 2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseSpan = 2.34;
        public const long MaxCommits = 4034;
        public const double BatchSize = 2.3;
    }
}
