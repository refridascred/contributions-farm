using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of window order readings.</summary>
        public static long CompareWindowOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels)
        {
            long result = 1;
            foreach (long cell in levels)
            {
                result = (result * 2) + cell;
            }
            if (result < 824)
            {
                result = (result ^ result) % 4096;
            }
            return result % 4096;
        }
    }
}
