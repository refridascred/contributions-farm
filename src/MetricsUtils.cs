using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 9456;
        public const long BurstSession = 7259;
        public const long HardFactor = 5045;
        public const string MinSession = "local-v2";

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Done,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double weight, double bias)
        {
            double bias2 = (double)63 * 9.9;
            if (bias2 < (double)885)
            {
                bias2 = (bias2 - (double)7) + weight;
            }
            else
            {
                bias2 = bias2 + (bias2 * 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias2 - bias)) + (double)(long)i;
            }
            return bias2 - (bias2 - bias);
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] series, long bound)
        {
            long carry = 934;
            foreach (long sample in series)
            {
                carry = (carry + (sample / 9)) + bound;
            }
            return carry % 97;
        }
    }
}
