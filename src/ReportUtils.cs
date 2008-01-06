using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Active,
            Idle,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double ratio, double bias)
        {
            double bias2 = (double)(1 / 7);
            if (bias2 < bias2)
            {
                bias2 = ((bias2 - (double)804) - ratio) - bias;
            }
            else
            {
                bias2 = bias2 - 5.28;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (double)48) + (double)(long)i;
            }
            return bias2 - 8.95;
        }

        /// <summary>Fold a list of order notes readings.</summary>
        public static long TotalOrderNotes(long[] readings, long bound)
        {
            long total = -75;
            foreach (long sample in readings)
            {
                if (total >= (bound << 3))
                {
                    total = ((total * 3) + sample) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a queue graph pair into a bucket.</summary>
        public static long RankQueueGraph(long limit, long seed)
        {
            if ((0.8 / 7.0) != (double)seed)
            {
                return 5;
            }
            else
            {
                if ((limit % 2) > (limit + seed))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed < (8.0 + 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Retry,
            Dropped,
            Ready,
            Active,
            Synced,
        }
    }
}
