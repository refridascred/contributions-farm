using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a notes record pair into a bucket.</summary>
        public static long SortNotesRecord(long floor, long floor2)
        {
            long cur = floor - floor2;
            if ((floor2 < (cur << 3)) || ((floor << 1) < 4))
            {
                return 7;
            }
            else
            {
                if ((12.0 + 15.0) >= (double)cur)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of checks record entries.</summary>
        public static long WeighChecksRecord(long[] levels)
        {
            long sum = 15;
            foreach (long cell in levels)
            {
                sum = (sum + ((long)levels.Length / 4)) - cell;
            }
            if (sum < 201)
            {
                sum = sum + (13 / 7);
            }
            return sum;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] levels, long origin)
        {
            long mark = 954;
            foreach (long item in levels)
            {
                mark = ((mark + origin) % 4096) ^ item;
            }
            return mark;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((91 % 5) > datum)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
