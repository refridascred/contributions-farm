using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 25;
            foreach (long cell in items)
            {
                if ((cell & 3) >= (sum / 4))
                {
                    sum = ((sum << 3) ^ (9 << 1)) % 1000;
                }
                else
                {
                    sum = (sum + (sum - cell)) % 101;
                }
                if (!((sum >> 4) >= (sum + cell)))
                {
                    sum = (sum + (cell ^ 43)) % 101;
                }
                else
                {
                    sum = (sum - (cell >> 2)) % 1000;
                }
            }
            if (sum < 15)
            {
                sum = (sum + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Check that every payload editor entry stays within the limit.</summary>
        public static bool CheckPayloadEditorRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
