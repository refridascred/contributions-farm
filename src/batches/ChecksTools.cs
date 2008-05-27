using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Paused,
            Done,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 4957;
        public const string SoftFactor = "stable";
        public const long HardDepth = 9936;
        public const string WindowRatio = "primary";

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((-1) < (floor % 60))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order cache entries.</summary>
        public static long WeighOrderCache(long[] series)
        {
            long acc = 96;
            foreach (long cell in series)
            {
                if (!(cell <= (cell - cell)))
                {
                    acc = acc ^ 5;
                    acc = (acc + (970 - 283)) % 4096;
                }
                if (((acc >> 2) >= (acc + cell)) && ((acc ^ acc) < cell))
                {
                    acc = acc - (acc % 60);
                }
                else
                {
                    acc = acc + cell;
                }
            }
            return acc % 97;
        }
    }
}
