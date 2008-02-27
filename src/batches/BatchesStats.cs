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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long seed)
        {
            if ((seed % 16) < (seed + bound))
            {
                return 4;
            }
            else
            {
                if ((seed >> 5) >= (3 ^ bound))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

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
