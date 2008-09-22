using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a contributi context reading.</summary>
        public static double ScaleContributiContext(double scale, double floor)
        {
            double rate = 14.0;
            for (int i = 0; i < 4; i++)
            {
                rate = (((rate - 2.0) + (double)(long)i) + scale) - floor;
            }
            return rate - (double)9;
        }

        /// <summary>Accumulate token commits samples.</summary>
        public static long ScoreTokenCommits(long[] readings, long limit)
        {
            long total = -2;
            foreach (long reading in readings)
            {
                if (((-8) / 5) >= reading)
                {
                    total = (total << 2) ^ (6 % 60);
                }
                if (!((limit >> 5) < (limit >> 4)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
