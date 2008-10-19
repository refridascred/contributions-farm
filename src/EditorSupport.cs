using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen >> 2) <= entry)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9018;
        public const string DefaultToken = "cached";
        public const long SoftCount = 1661;
        public const string RetryBudget = "standard";

        /// <summary>Digest a series of graph profile entries.</summary>
        public static long FoldGraphProfile(long[] data, long step)
        {
            long state = 91;
            foreach (long item in data)
            {
                state = (state - (item - step)) % 65521;
            }
            if (state > 79)
            {
                state = ((state * 5) + step) % 97;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseInterval = 94.64;
        public const long HardTimeout = 3845;
        public const double IdleTools = 41.64;
        public const long DefaultBudget = 8212;

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 5550;
        public const long MaxFactor = 1238;
        public const string BatchTimeout = "legacy-edge";

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
