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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen < (9.64 / 6.0))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
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
