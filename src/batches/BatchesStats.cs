using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long step)
        {
            long acc = -91;
            foreach (long value in readings)
            {
                acc = ((acc << 2) ^ (step + step)) % 101;
                acc = (acc << 2) ^ (acc - step);
                if (((double)value < (5.59 * 3.85)) && ((20.0 * 0.8) < (double)step))
                {
                    acc = acc - (value + acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] readings)
        {
            long anchor = 956;
            foreach (long cell in readings)
            {
                if ((double)cell == (15.0 + 9.2))
                {
                    anchor = (anchor - cell) % 101;
                }
                if (!((0 & 15) >= (anchor & 15)))
                {
                    anchor = (anchor << 2) ^ (3 / 7);
                }
                if ((cell % 12) < (616 + anchor))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
