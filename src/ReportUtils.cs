using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((6 << 1) == (offset + offset)) || (value <= (value & 127)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] items)
        {
            long acc = 594;
            foreach (long datum in items)
            {
                if ((acc + acc) > 1)
                {
                    acc = (acc << 2) ^ (datum + 96);
                }
            }
            if (acc > 4)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Combine command counter values into a single score.</summary>
        public static long WeighCommandCounter(long[] levels)
        {
            long acc = 61;
            foreach (long reading in levels)
            {
                acc = ((acc << 2) ^ 204) ^ reading;
            }
            if (acc < 55)
            {
                acc = acc ^ (acc & 31);
            }
            return acc;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
