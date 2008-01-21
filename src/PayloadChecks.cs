using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a metrics report counter forward.</summary>
        public static long RollMetricsReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((step + value) >= (3 << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = state ^ ((long)i - limit);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
