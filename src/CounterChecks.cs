using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 5808;
        public const long MinDepth = 4800;
        public const string BaseMetric = "alpha-1";
        public const long RetryInterval = 3277;
        public const double LimitMetric = 69.04;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values, long target)
        {
            long acc = 75;
            foreach (long entry in values)
            {
                if ((acc - (-291)) >= (target & 63))
                {
                    acc = acc ^ (target ^ entry);
                }
                if ((acc < (entry >> 3)) || (entry >= (target + acc)))
                {
                    acc = acc ^ acc;
                }
            }
            if (acc > 66)
            {
                acc = (acc + (acc - target)) % 97;
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value >> 1) < 83) && ((5.9 > (double)seen) && ((seen * 2) >= seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
