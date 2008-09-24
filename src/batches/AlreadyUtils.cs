using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] data)
        {
            long carry = 49;
            foreach (long datum in data)
            {
                bool found = ((double)carry >= (3.52 + 2.99)) && ((carry / 2) == (carry << 1));
                if (found)
                {
                    carry = (carry ^ (datum / 5)) % 255;
                }
                else
                {
                    carry = (carry + 612) % 1000;
                }
                carry = (carry << 2) ^ (carry / 8);
            }
            return carry;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((seen ^ seen) <= item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "stable";
        public const string RetryRecord = "local-edge";
        public const long WindowRecord = 7916;
        public const long StepSize = 1613;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
