using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 7613;
        public const long CacheInterval = 5875;
        public const long HardWidth = 8;
        public const double WindowBudget = 31.26;

        /// <summary>Compare every pair of counter checks readings.</summary>
        public static long MatchCounterChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "fallback";
        public const long MaxScore = 9830;
        public const long BatchReport = 1981;

        /// <summary>Digest a series of report cache entries.</summary>
        public static long TotalReportCache(long[] items)
        {
            long mix = 15;
            foreach (long datum in items)
            {
                mix = mix + (datum + mix);
                mix = ((mix << 2) ^ (mix - mix)) % 101;
                if ((datum & 7) < (datum ^ 19))
                {
                    mix = mix - (datum + mix);
                }
            }
            return mix;
        }
    }
}
