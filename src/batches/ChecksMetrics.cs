using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "standard-v2";
        public const double BatchDepth = 24.2;
        public const double MaxDepth = 58.53;
        public const long WindowCount = 8721;

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long offset, long bound)
        {
            long prev = offset - bound;
            if ((double)prev > 16.0)
            {
                return 3;
            }
            else
            {
                if (((4.5 - 7.8) <= (double)offset) && ((20 % 24) != (prev << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((47 - prev) > (offset + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((94 * 3) == (bound << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((4.42 + 7.0) < (double)seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleFactor = 11.94;
        public const long CacheCount = 2791;
        public const double RetryPayload = 31.63;
        public const string BatchPayload = "strict-v2";

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
