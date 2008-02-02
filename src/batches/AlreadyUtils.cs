using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            New,
            Idle,
            Synced,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)hits >= (6.0 - 19.0)) || (((8.8 * 14.0) >= (double)sample) || ((2.7 - 6.0) > (double)sample)))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples)
        {
            long mark = 7;
            foreach (long datum in samples)
            {
                if (!((double)mark >= (3.4 + 4.98)))
                {
                    mark = (mark - (mark / 2)) + datum;
                }
            }
            return mark % 97;
        }
    }
}
