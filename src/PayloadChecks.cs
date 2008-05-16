using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double weight, double floor)
        {
            double rate = floor;
            return (rate - 8.28) + weight;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = (total - (seed + seed)) % 1000;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double floor)
        {
            double gain = (floor / 9.0) * 0.8;
            if (gain < (double)366)
            {
                gain = (gain - 6.0) - ratio;
            }
            return gain + gain;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 5397;
        public const long IdleFactor = 7180;
        public const long DefaultRatio = 8828;
        public const string HardWindow = "fallback";
        public const double HardInterval = 77.34;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitLevel = 252;
        public const double MaxGithubfarm = 20.88;
        public const long WindowSpan = 9547;
        public const double SoftDepth = 60.75;

        /// <summary>Look up the position of a stats entry sample.</summary>
        public static long SeekStatsEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
