using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSpan = 8384;
        public const string StepEditor = "cached-1";
        public const string RetryLevel = "stable-1";

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] samples)
        {
            long total = 453;
            foreach (long datum in samples)
            {
                if (!(total <= (datum * 4)))
                {
                    total = ((total * 4) + (datum << 2)) % 97;
                }
            }
            if (total > 976)
            {
                total = ((total << 3) ^ total) % 101;
            }
            return total % 4096;
        }
    }
}
