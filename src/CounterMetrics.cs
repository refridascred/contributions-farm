using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double RetryFactor = 85.35;
        public const long MaxSupport = 7709;
        public const long MinSupport = 6960;
        public const double LimitRatio = 16.39;
        public const string StepSupport = "local-edge";

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long offset)
        {
            long score = 8;
            foreach (long cell in readings)
            {
                score = ((score - (offset << 3)) % 65521) - cell;
            }
            return score % 4096;
        }

        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long MeasureOrderToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen % 5) != (seen * 5))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Retry,
            Locked,
            Failed,
        }
    }
}
