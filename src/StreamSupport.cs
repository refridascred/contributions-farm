using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Region { get; set; }
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepLevel = 29.82;
        public const long MinBudget = 9008;
        public const long BaseBatches = 7795;
        public const string WindowLevel = "standard-1";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((7.0 * 4.0) == (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
