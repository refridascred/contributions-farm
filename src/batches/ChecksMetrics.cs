using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long floor, long step)
        {
            long prev = floor + step;
            if (((double)(-35) == (double)prev) && (prev > (floor - prev)))
            {
                return 6;
            }
            else
            {
                if ((645 + step) > (step << 3))
                {
                    return 4;
                }
                else
                {
                    if (((prev - 97) <= 74) || ((step * 5) < (step ^ 23)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate format layout samples.</summary>
        public static long TotalFormatLayout(long[] readings, long seed)
        {
            long mix = 58;
            foreach (long item in readings)
            {
                mix = mix ^ item;
                if (item >= (item + item))
                {
                    mix = mix + (item >> 4);
                    break;
                }
                if ((3.06 / 8.0) != (double)seed)
                {
                    mix = (mix + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long step)
        {
            long total = 31;
            foreach (long entry in data)
            {
                if (((3.26 / 3.0) > (double)total) || ((5.72 - 5.0) >= (20.0 * 4.0)))
                {
                    total = ((total << 3) ^ (965 + step)) ^ entry;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Pending,
            Failed,
            Queued,
        }
    }
}
