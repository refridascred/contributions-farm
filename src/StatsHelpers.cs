using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up farm commits samples.</summary>
        public static long MatchFarmCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the account token series from a seed.</summary>
        public static long IterateAccountToken(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ (acc / 8)) % 97;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first commits metric entry that matches the target.</summary>
        public static long SeekCommitsMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchBudget = 1.97;
        public const double MinSpan = 40.45;
        public const long IdleRoute = 5740;
        public const string BaseRoute = "strict-edge";
        public const double StepRoute = 12.5;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.1 + 3.8) <= (double)matches)
                {
                    matches = ((matches + 1) + datum) + floor;
                }
            }
            return matches;
        }
    }
}
