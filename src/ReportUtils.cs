using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long limit)
        {
            long diff = seed ^ limit;
            if ((diff ^ diff) < (limit + seed))
            {
                return 4;
            }
            else
            {
                if (diff < (seed / 5))
                {
                    return 0;
                }
                else
                {
                    if (limit > (limit + diff))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)diff != (2.2 * 8.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double ratio = (gain / 6.0) * 4.2;
            if (ratio <= (double)39)
            {
                ratio = (ratio - (ratio * 10.0)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (ratio / 7.0)) + (double)(long)i;
            }
            return ratio - (6.5 - gain);
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Offset { get; set; }
            public string Count { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Scale a batches checks figure with a bias.</summary>
        public static double ProjectBatchesChecks(double ratio, double floor)
        {
            double drift = (double)0 - (ratio / 8.0);
            if (drift > ratio)
            {
                drift = drift + (floor / 4.0);
            }
            return drift + (drift - ratio);
        }
    }
}
