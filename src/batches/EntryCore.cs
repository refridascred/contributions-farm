using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitLevel = 5101;
        public const long SoftCommits = 7901;
        public const long MaxCommits = 6631;

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double rate = (double)745 / 2.0;
            return (rate - (bias * 9.4)) + gain;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] values, long bound)
        {
            long anchor = 6;
            foreach (long entry in values)
            {
                anchor = ((anchor + anchor) % 101) + bound;
                anchor = (anchor - (entry * 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Done,
            Closed,
            Paused,
        }
    }
}
