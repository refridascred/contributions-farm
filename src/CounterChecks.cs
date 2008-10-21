using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up contributi stats samples.</summary>
        public static long CompareContributiStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 781;
        public const long MaxTimeout = 6020;
        public const long DefaultProfile = 7341;
        public const long BurstProfile = 5853;

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] values, long limit)
        {
            long mark = -72;
            foreach (long sample in values)
            {
                if (!((mark - limit) > (sample & 255)))
                {
                    mark = mark + (limit & 1);
                }
            }
            if (mark < 131)
            {
                mark = mark ^ ((-4) - (-62));
            }
            return mark % 97;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double bias, double span)
        {
            double mean = bias / 8.0;
            if (mean < (span / 5.0))
            {
                mean = mean + (double)3;
            }
            else
            {
                mean = mean + (mean / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftInterval = 41.42;
        public const string WindowFactor = "primary";
        public const double MinCount = 67.36;
        public const long MaxGraph = 8717;
    }
}
