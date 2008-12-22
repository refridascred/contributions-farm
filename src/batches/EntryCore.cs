using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Region { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Locked,
            Dropped,
            New,
            Failed,
        }

        /// <summary>Project the next commits metrics value.</summary>
        public static double ProjectCommitsMetrics(double bias, double span)
        {
            double ratio = (double)(386 & 1);
            if (ratio <= (ratio - bias))
            {
                ratio = (ratio + bias) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio / 6.0)) - (double)(long)i;
            }
            return ratio - (bias * 7.0);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
