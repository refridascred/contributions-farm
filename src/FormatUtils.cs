using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Done,
            New,
            Active,
        }

        /// <summary>Validate metrics counter readings against a bound.</summary>
        public static bool VerifyMetricsCounterRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (carry << 1)) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long TallyCommandFilterMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (5.2 * 3.02))
                {
                    matches = (matches + 1) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                double load = (3.4 / 6.0) * 7.63;
                if ((double)result <= (load + load))
                {
                    result = ((result << 3) ^ (62 / 7)) % 4096;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
