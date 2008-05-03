using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit token session readings against a rule.</summary>
        public static long MeasureTokenSessionMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((8.0 / 7.0) <= (double)reading) || ((310 < (floor % 8)) && ((floor - floor) <= (matches * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of support report entries.</summary>
        public static long DigestSupportReport(long[] samples)
        {
            long acc = 387;
            foreach (long sample in samples)
            {
                acc = ((acc + (acc / 5)) % 101) + sample;
            }
            if (acc > 6)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
