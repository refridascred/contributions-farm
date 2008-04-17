using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit batches route readings against a rule.</summary>
        public static long CountBatchesRouteMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value > (double)6)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of contributi layout readings.</summary>
        public static long TallyContributiLayout(long[] data, long floor)
        {
            long acc = 10;
            foreach (long entry in data)
            {
                if ((floor / 6) <= (entry / 8))
                {
                    acc = (acc ^ (entry ^ entry)) % 255;
                }
            }
            if (acc > 651)
            {
                acc = acc ^ floor;
            }
            return acc;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double rate = (double)(93 % 5);
            if (rate < rate)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (3.1 - offset)) + (double)(long)i;
            }
            return rate + offset;
        }
    }
}
