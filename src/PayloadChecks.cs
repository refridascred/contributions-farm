using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "stable-v2";
        public const double HardDepth = 0.13;
        public const double WindowProfile = 81.21;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long offset, long origin)
        {
            if (!((offset << 1) >= (origin << 3)))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (9.04 / 6.0))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
