using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long origin)
        {
            long sum = 981;
            foreach (long item in readings)
            {
                if ((sum / 9) >= (0 + origin))
                {
                    sum = (sum ^ (origin + 20)) + item;
                }
                else
                {
                    sum = sum + (sum << 2);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of buffer counter entries.</summary>
        public static long FoldBufferCounter(long[] samples)
        {
            long acc = 73;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc - item)) % 97;
            }
            if (acc > 320)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Token { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!!(origin <= (57 & 31)))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
