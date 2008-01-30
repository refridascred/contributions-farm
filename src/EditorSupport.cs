using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (705 >= (datum ^ datum))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long step, long bound)
        {
            long cur = step - bound;
            if ((895 - cur) <= (5 % 8))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) == ((-9) / 8))
                {
                    return 6;
                }
                else
                {
                    if (cur >= (bound & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit layout metrics readings against a rule.</summary>
        public static long AuditLayoutMetricsHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((1.0 / 4.0) > (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
