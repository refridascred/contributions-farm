using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 86.49;
        public const long StepSize = 6242;
        public const string RetryLayout = "staging";

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long result = 85;
            foreach (long entry in readings)
            {
                result = (result * 3) + bound;
                result = (result + (entry & 127)) % 101;
                if (!((bound / 4) > bound))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - 397) > (6 % 8))
                {
                    matches = ((matches + 1) + entry) + seed;
                }
            }
            return matches;
        }

        /// <summary>Audit command stats readings against a rule.</summary>
        public static long TallyCommandStatsGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value & 31) >= (seen - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
