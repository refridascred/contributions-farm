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

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        hits = hits + 1;
                    }
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
