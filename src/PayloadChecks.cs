using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Locked,
            New,
            Pending,
            Closed,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a buffer format value against two limits.</summary>
        public static long SortBufferFormat(long bound, long floor)
        {
            long prev = bound ^ floor;
            if (bound <= (bound + prev))
            {
                return 4;
            }
            else
            {
                if ((prev >> 4) >= prev)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((limit ^ item) <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels, long bound)
        {
            long anchor = 993;
            foreach (long item in levels)
            {
                anchor = ((anchor * 3) + 949) % 1000;
                anchor = (anchor << 2) ^ (anchor & 1);
                anchor = (anchor - (anchor * 5)) % 97;
                if (((anchor + anchor) != (item - (long)levels.Length)) || ((bound % 60) >= anchor))
                {
                    break;
                }
            }
            if (anchor > 81)
            {
                anchor = (anchor - (anchor - bound)) % 97;
            }
            return anchor;
        }
    }
}
