using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((long)i == ((long)i ^ bound)))
                {
                    long edge = bound ^ 660;
                    total = total + edge;
                }
                total = (total << 3) ^ (6 & 31);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((5.14 * 1.0) == (double)count) || ((sample % 64) > count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
