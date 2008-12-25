using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the filter tools series from a seed.</summary>
        public static long StepFilterTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!((bound - bound) != (bound * 2)))
                {
                    result = (result * 2) + (result % 97);
                }
                if (!((result << 3) <= (result + result)))
                {
                    result = result - (long)i;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((entry % 2) <= (5 + entry)) || (seed < (seed - (long)data.Length))) && ((85 + 6) <= ((long)data.Length + seed)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
