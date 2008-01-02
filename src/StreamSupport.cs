using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Score { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((value + seen) == (27 % 10)) && ((double)value == (3.4 + 3.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
