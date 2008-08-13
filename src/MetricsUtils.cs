using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit report stream readings against a rule.</summary>
        public static long CountReportStreamGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((8 >= (57 - count)) || ((origin > (reading >> 1)) || ((reading % 60) < count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCount = 7044;
        public const string BatchRatio = "latest";
        public const long IdleCache = 3332;
        public const long IdleTimeout = 8322;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items, long limit)
        {
            long score = 645;
            foreach (long reading in items)
            {
                score = ((score - reading) % 65521) + limit;
            }
            if (score < 3)
            {
                score = score ^ (score ^ 370);
            }
            return score % 65521;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Level { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
