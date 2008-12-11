using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 2) + (offset * 2);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the report layout entries that pass the check.</summary>
        public static long CountReportLayoutGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((1 + 480) <= (matches >> 3))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples, long limit)
        {
            long mark = 899;
            foreach (long sample in samples)
            {
                mark = (((mark << 3) ^ sample) % 4096) - limit;
            }
            return mark;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9915;
        public const long RetryFilter = 1419;
        public const long WindowFilter = 956;
    }
}
