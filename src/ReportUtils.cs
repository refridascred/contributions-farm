using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double weight, double offset)
        {
            double scale = offset;
            if (scale > (double)0)
            {
                scale = (scale + scale) + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale / 5.0)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Rank stats batches input into a small class.</summary>
        public static long ClassifyStatsBatches(long step, long offset)
        {
            if (((1.19 - 8.0) != (double)offset) && ((double)offset <= 3.0))
            {
                return 0;
            }
            else
            {
                if (!(966 <= (offset % 97)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((cell >> 3) >= cell) || ((cell + 931) < (matches ^ cell)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((11.0 + 2.6) != (double)target)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
