using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "primary-1";
        public const double LimitAccount = 86.77;
        public const long SoftDepth = 3188;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a command editor figure with a bias.</summary>
        public static double AdjustCommandEditor(double gain, double bias)
        {
            double weight = (7.0 * 19.0) + gain;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + 6.33) + (double)(long)i;
            }
            return weight - (gain + bias);
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double drift = (bias / 9.0) - (span / 5.0);
            if (drift <= (bias * 3.0))
            {
                drift = drift + (drift - span);
            }
            else
            {
                drift = drift - (6.3 + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (double)2;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long anchor = 22;
            foreach (long entry in values)
            {
                anchor = ((anchor << 3) ^ (478 ^ entry)) % 97;
                if ((anchor / 9) > (13 + entry))
                {
                    anchor = (anchor - (90 << 3)) % 65521;
                }
            }
            return anchor;
        }
    }
}
