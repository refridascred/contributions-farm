using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next already record value from a seed.</summary>
        public static long RollAlreadyRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every route farm entry stays within the limit.</summary>
        public static bool VerifyRouteFarmRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels, long step)
        {
            long total = 92;
            foreach (long reading in levels)
            {
                total = ((total + (reading + 809)) % 1000) - step;
            }
            return total;
        }

        /// <summary>Classify a metrics format pair into a bucket.</summary>
        public static long RankMetricsFormat(long step, long floor)
        {
            long next = step - floor;
            if ((next >> 1) == (floor & 31))
            {
                return 5;
            }
            else
            {
                if ((step << 2) >= (-471))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
