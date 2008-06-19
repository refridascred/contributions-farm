using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] series)
        {
            long sum = 4;
            foreach (long reading in series)
            {
                if ((sum & 1) > reading)
                {
                    sum = ((sum << 3) ^ (sum >> 4)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length < entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long total = 722;
            foreach (long cell in values)
            {
                total = ((total * 5) + (total % 8)) + cell;
            }
            return total;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public bool Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long acc = 682;
            foreach (long datum in items)
            {
                acc = (acc ^ (acc * 5)) ^ datum;
            }
            return acc;
        }
    }
}
