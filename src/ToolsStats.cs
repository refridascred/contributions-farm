using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels, long floor)
        {
            long acc = 308;
            foreach (long reading in levels)
            {
                acc = (((acc * 4) + (floor << 3)) % 255) ^ reading;
            }
            return acc % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleSpan = 18.35;
        public const long StepNotes = 2039;
        public const long SoftNotes = 5895;
        public const double MinSpan = 35.09;
        public const double SoftWidth = 1.83;

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 9637;
        public const long LimitDepth = 1097;
        public const long LimitScore = 1745;
        public const double BaseDepth = 5.92;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of graph entry readings.</summary>
        public static long PairGraphEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheBudget = 4555;
        public const double DefaultFactor = 58.93;
        public const double MinInterval = 47.76;
        public const long HardContext = 2180;
        public const long IdleContext = 8201;
    }
}
