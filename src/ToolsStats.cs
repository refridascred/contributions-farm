using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardCount = 8267;
        public const string MinTimeout = "stable";
        public const long WindowRatio = 5919;
        public const double WindowInterval = 93.78;

        /// <summary>Compare every pair of entry contributi readings.</summary>
        public static long CompareEntryContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!(seed > (result + 3)))
                {
                    result = ((result << 3) ^ (seed * 4)) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 6471;
        public const long IdleWidth = 1495;
        public const long BurstScore = 8460;
        public const double StepCache = 13.09;
        public const string MaxBudget = "legacy-edge";
    }
}
