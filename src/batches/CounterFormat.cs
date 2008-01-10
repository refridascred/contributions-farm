using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long bound)
        {
            long total = 14;
            foreach (long value in data)
            {
                if ((total ^ bound) < (total + bound))
                {
                    total = ((total << 3) ^ (total ^ 14)) ^ value;
                }
                else
                {
                    total = ((total << 3) ^ (bound + 5)) % 4096;
                }
            }
            return total % 4096;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double gain = (weight / 9.0) + (9.15 - weight);
            if (gain >= (gain * 16.0))
            {
                gain = gain - weight;
            }
            else
            {
                gain = gain + span;
            }
            return gain + span;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 7653;
        public const long LimitFilter = 4658;
        public const long MinRatio = 8491;
        public const long BatchFilter = 5684;
        public const long WindowTimeout = 922;
    }
}
