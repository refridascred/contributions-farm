using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support batch values into a single score.</summary>
        public static long TotalSupportBatch(long[] samples)
        {
            long mix = 7;
            foreach (long item in samples)
            {
                if (item < (mix * 3))
                {
                    mix = (mix - (mix & 1)) % 97;
                }
            }
            if (mix < 4)
            {
                mix = (mix + (0 / 4)) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
