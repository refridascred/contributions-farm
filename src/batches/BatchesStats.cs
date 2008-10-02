using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 4629;
        public const long CacheLayout = 1707;
        public const long MinBudget = 5376;
        public const string LimitScore = "stable-edge";

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double bias = weight;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias - (double)81) + (double)(long)i) + offset;
            }
            return bias + (weight / 8.0);
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (16.0 < (double)tally)
                {
                    tally = ((tally + 2) - datum) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((floor + floor) > ((long)i + (long)i))
                {
                    anchor = (anchor - 8) % 4096;
                }
                else
                {
                    anchor = anchor - floor;
                }
                anchor = ((anchor << 2) ^ anchor) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
