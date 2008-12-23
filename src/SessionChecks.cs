using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((step + step) >= (step / 4)) && ((sample > (count << 2)) && ((double)sample != (5.73 * 8.0))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long origin)
        {
            long prev = offset + origin;
            if ((offset << 2) > 3)
            {
                return 8;
            }
            else
            {
                if (707 <= prev)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
