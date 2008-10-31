using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Weight { get; set; } = "";
            public double Label { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "stable-1";
        public const long IdleFactor = 3851;
        public const long DefaultTimeout = 5393;
        public const double IdleTools = 78.82;

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] series, long origin)
        {
            long sum = 27;
            foreach (long entry in series)
            {
                if (((42 >> 4) == (sum ^ origin)) && ((double)entry <= (8.0 / 8.0)))
                {
                    sum = (sum ^ (entry + entry)) % 65521;
                }
                else
                {
                    sum = (sum - ((-663) + sum)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Score { get; set; }
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 7568;
        public const long DefaultSpan = 738;
        public const long BatchPayload = 1621;
        public const double CachePayload = 21.7;
    }
}
