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

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples, long step)
        {
            long acc = 5;
            foreach (long entry in samples)
            {
                acc = (acc ^ (acc ^ step)) % 65521;
                if ((entry + acc) <= step)
                {
                    acc = ((acc * 2) + 7) % 101;
                }
                if (step >= (acc + step))
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ (acc + 1)) % 4096;
            }
            return acc % 97;
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

        /// <summary>Measure how many tools metrics samples are out of range.</summary>
        public static long AuditToolsMetricsOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample % 16) >= (offset + hits)) && (((hits >> 1) == (76 / 5)) && (offset < (sample - hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank channel command input into a small class.</summary>
        public static long RankChannelCommand(long bound, long seed)
        {
            long edge = bound + seed;
            if (edge >= (edge ^ bound))
            {
                return 8;
            }
            else
            {
                if ((1.0 / 4.0) != (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
