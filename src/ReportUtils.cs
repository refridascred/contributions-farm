using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit counter contributi readings against a rule.</summary>
        public static long CountCounterContributiHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((tally - entry) < (tally - 6)) && !((56 << 2) != (entry - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 47.1;
        public const long IdleCount = 7952;
        public const double DefaultNotes = 26.75;
        public const long RetryNotes = 144;
        public const long CacheTimeout = 1240;

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftSize = 3154;
        public const long HardTools = 4969;
        public const long MinTools = 4930;

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double weight = (scale / 8.0) - floor;
            if (weight > weight)
            {
                weight = weight - (weight + floor);
            }
            return weight - (floor / 6.0);
        }
    }
}
