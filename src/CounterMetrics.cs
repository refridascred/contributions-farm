using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
