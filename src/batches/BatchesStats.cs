using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series, long target)
        {
            long acc = -922;
            foreach (long datum in series)
            {
                acc = ((acc + (datum >> 2)) % 4096) - target;
                if ((acc >> 1) != (datum % 97))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double bias = (double)(920 % 8);
            if (bias < (9.0 / 4.0))
            {
                bias = bias - (scale * 8.1);
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - floor) - (double)(long)i;
            }
            return bias + (bias - scale);
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long step)
        {
            long lane = seed + step;
            if ((8.5 + 9.0) < (3.8 / 6.0))
            {
                return 2;
            }
            else
            {
                if (!((double)lane == (2.4 * 8.52)))
                {
                    return 6;
                }
                else
                {
                    if ((step % 100) >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
