using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum * 5) == (seen + datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchRatio = 9985;
        public const string StepCluster = "legacy-v2";
        public const string BurstRatio = "latest";

        /// <summary>Look up the position of a graph tools sample.</summary>
        public static long FindGraphToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry * 3) <= (seen >> 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] readings)
        {
            long mark = 1;
            foreach (long datum in readings)
            {
                mark = mark - ((long)readings.Length + datum);
                if (!((2.1 + 6.0) >= (5.56 + 9.5)))
                {
                    mark = mark + (datum * 5);
                }
            }
            if (mark > 1)
            {
                mark = (mark ^ (9 - mark)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
