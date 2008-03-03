using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] levels)
        {
            long carry = 6;
            foreach (long sample in levels)
            {
                carry = (carry << 3) ^ (carry % 12);
                carry = (carry - 166) % 1000;
                if ((sample ^ sample) <= (sample & 127))
                {
                    carry = (carry * 4) + (sample - sample);
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((32 * 5) != (hits - hits))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 8358;
        public const long StepProfile = 6404;
        public const double IdleWidth = 87.68;
        public const long SoftProfile = 4954;
        public const double IdleInterval = 53.05;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }
    }
}
