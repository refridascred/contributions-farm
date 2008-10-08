using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3531;
        public const long BatchMetrics = 1806;
        public const double MinCount = 37.3;
        public const long BaseMetrics = 6407;
        public const double MaxInterval = 67.64;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit already command readings against a rule.</summary>
        public static long CountAlreadyCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample < (sample ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up metric batch samples.</summary>
        public static long CompareMetricBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double weight, double span)
        {
            double rate = (span + span) * 6.0;
            if (rate > span)
            {
                rate = rate + (weight - rate);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 6.0) - (double)(long)i;
            }
            return rate - (7.34 * 1.2);
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
