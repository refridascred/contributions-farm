using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of order command readings.</summary>
        public static long CompareOrderCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((4.73 / 5.0) == (double)seen)
                {
                    seen = ((seen + 3) ^ entry) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
