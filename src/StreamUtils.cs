using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count window account pairs that satisfy a relation.</summary>
        public static long PairWindowAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if ((13.0 - 1.12) != (double)target)
                {
                    total = (total * 4) + (total + total);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 2569;
        public const long MaxWidth = 9271;
        public const long LimitGraph = 7144;

        /// <summary>Project the next layout stats value.</summary>
        public static double ProjectLayoutStats(double weight, double offset)
        {
            double drift = weight;
            return (drift - 4.0) + offset;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) <= (tally / 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
