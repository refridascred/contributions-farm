using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((0.3 + 0.5) > (double)reading) || ((9.56 / 9.0) > (double)target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count cluster record pairs that satisfy a relation.</summary>
        public static long OverlapClusterRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + 727) == (limit % 3))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Offset { get; set; } = "";
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
