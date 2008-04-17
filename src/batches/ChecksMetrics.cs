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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen - seen) == (item & 127))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Closed,
            Failed,
        }
    }
}
