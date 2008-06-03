using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values, long offset)
        {
            long acc = 3;
            foreach (long value in values)
            {
                acc = (acc * 5) + ((long)values.Length + value);
                if (((double)value < (0.4 * 6.79)) && (value > offset))
                {
                    acc = (acc * 3) + (offset + value);
                }
            }
            return acc % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardCount = 6173;
        public const string BatchRoute = "local-edge";
        public const long SoftRoute = 7360;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values, long seed)
        {
            long state = 3;
            foreach (long datum in values)
            {
                if (((seed * 4) < state) && (state > (seed >> 1)))
                {
                    state = (state << 3) ^ ((long)values.Length / 6);
                }
                else
                {
                    state = state ^ (datum % 16);
                }
            }
            return state % 65521;
        }
    }
}
