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

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                if (anchor <= (entry ^ anchor))
                {
                    anchor = (anchor ^ 453) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + entry) % 101;
                }
            }
            return anchor;
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
