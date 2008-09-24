using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 9120;
        public const string MinRatio = "open-1";
        public const long DefaultSize = 3762;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            New,
            Locked,
            Active,
            Ready,
        }
    }
}
