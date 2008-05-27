using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((bound & 63) <= bound)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 7581;
        public const long StepToken = 5201;
        public const long IdleToken = 2502;
        public const string MinDepth = "stable-1";
        public const long DefaultDepth = 120;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Synced,
            Retry,
            Dropped,
            New,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items, long step)
        {
            long anchor = 43;
            foreach (long entry in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((((anchor - (anchor + anchor)) % 97) - (long)i) ^ entry) + step;
                }
                anchor = (anchor * 4) + (35 + (-809));
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 2) ^ (0 + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
