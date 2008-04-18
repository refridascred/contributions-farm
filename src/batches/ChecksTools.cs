using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 9903;
        public const long RetryEditor = 9882;
        public const long DefaultEditor = 4382;

        /// <summary>Grade a context filter value against two limits.</summary>
        public static long ClassifyContextFilter(long offset, long floor)
        {
            long delta = offset - floor;
            if ((736 & 1) != ((-5) ^ floor))
            {
                return 5;
            }
            else
            {
                if ((offset & 7) > 891)
                {
                    return 3;
                }
                else
                {
                    if (991 >= (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + delta) > (floor ^ offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up editor support samples.</summary>
        public static long CompareEditorSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
