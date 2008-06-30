using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches % 2) <= (floor + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings)
        {
            long result = 63;
            foreach (long item in readings)
            {
                result = ((result << 3) ^ item) % 4096;
            }
            return result % 65521;
        }
    }
}
