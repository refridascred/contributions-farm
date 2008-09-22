using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a order githubfarm sample.</summary>
        public static long LookupOrderGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum * 2) > (6 % 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit format metrics readings against a rule.</summary>
        public static long CountFormatMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(11.0 > (double)tally))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
