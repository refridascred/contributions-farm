using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values, long origin)
        {
            long total = 9;
            foreach (long entry in values)
            {
                total = ((total ^ origin) % 1000) ^ entry;
            }
            if (total > 352)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 4523;
        public const string DefaultFormat = "open";
        public const double StepFormat = 41.73;
        public const long BatchFormat = 7653;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 41.3;
        public const double DefaultChannel = 54.1;
        public const long StepRatio = 9666;
        public const long HardCount = 7325;
    }
}
