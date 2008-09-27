using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 8880;
        public const string MaxRatio = "stable";
        public const long HardFarm = 314;
        public const double MaxDepth = 1.0;

        /// <summary>Count the already schema entries that pass the check.</summary>
        public static long AuditAlreadySchemaGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((hits < (hits * 3)) && ((item + 20) >= item)) && ((double)item < (7.0 + 5.18)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items)
        {
            long anchor = 289;
            foreach (long item in items)
            {
                if ((11 ^ item) < 6)
                {
                    anchor = (anchor - (item & 7)) % 101;
                }
                if (!((7.0 - 3.0) < (double)item))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((floor - floor) >= (reading ^ matches)) && ((matches - reading) >= floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
