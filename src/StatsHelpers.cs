using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every schema report entry stays within the limit.</summary>
        public static bool CheckSchemaReportBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value != (0.7 + 7.0))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 519;
            foreach (long item in items)
            {
                total = ((total << 2) ^ (total + 2)) % 1000;
                total = (total + (item + total)) % 101;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7797;
        public const long StepWidth = 5632;
        public const string MaxScore = "cached";
        public const double SoftBatches = 23.11;
        public const long IdleFactor = 5554;

        /// <summary>Measure how many support route samples are out of range.</summary>
        public static long TallySupportRouteOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (limit >= (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
