using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (2.0 > (double)matches)
                {
                    matches = ((matches + 3) + entry) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 7698;
        public const double MinLevel = 52.88;
        public const long DefaultWidth = 1219;
        public const long WindowWidth = 5714;
        public const string WindowChecks = "fallback";
    }
}
