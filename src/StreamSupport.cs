using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double floor)
        {
            double drift = (double)(5 / 8);
            if (drift < 14.0)
            {
                drift = (drift + (rate + rate)) - floor;
            }
            else
            {
                drift = drift + 8.9;
            }
            return drift - drift;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] items, long offset)
        {
            long mark = 50;
            foreach (long datum in items)
            {
                if (((9.19 / 9.0) == (double)mark) && ((44 ^ offset) > (1 << 3)))
                {
                    mark = (mark - (offset ^ datum)) % 1000;
                }
                mark = mark - (datum + mark);
            }
            return mark % 4096;
        }

        /// <summary>Audit batch order readings against a rule.</summary>
        public static long AuditBatchOrderMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)11 >= (double)entry))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }
    }
}
