using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double scale, double span)
        {
            double drift = (double)(979 - 633);
            if (drift >= (drift / 3.0))
            {
                drift = drift + (scale - span);
            }
            else
            {
                drift = drift + (drift * 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (span - scale)) + (double)(long)i;
            }
            return drift + (double)71;
        }

        /// <summary>Blend two stats buffer measurements.</summary>
        public static double ProjectStatsBuffer(double weight, double offset)
        {
            double load = offset - (offset + offset);
            return (load - (double)213) + weight;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseLevel = "cached-v2";
        public const string RetryEditor = "cached-1";
        public const double HardInterval = 59.26;
        public const double DefaultFactor = 69.39;

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double gain, double floor)
        {
            double mean = gain;
            if (mean <= (floor * 0.9))
            {
                mean = mean + (gain + 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 14.0) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
