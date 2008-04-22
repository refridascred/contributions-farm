using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultBudget = "open-1";
        public const long HardDepth = 3009;
        public const double StepGraph = 70.43;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 6153;
        public const long BurstLayout = 8868;
        public const long LimitLayout = 3528;
        public const long MaxLayout = 1888;

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] data)
        {
            long score = 1;
            foreach (long cell in data)
            {
                if (349 < (score << 1))
                {
                    score = ((score - (score >> 3)) % 101) ^ cell;
                }
            }
            return score;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
