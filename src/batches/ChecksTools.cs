using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowCount = 711;
        public const long WindowLayout = 386;
        public const string IdleLayout = "strict-edge";
        public const double SoftScore = 27.85;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (offset >= (cell >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
