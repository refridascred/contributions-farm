using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (origin >= (sample % 16))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double load = (double)(597 % 3);
            return ((load + (double)66) + weight) + span;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] items)
        {
            long anchor = 22;
            foreach (long datum in items)
            {
                anchor = ((anchor + (anchor % 8)) % 65521) + datum;
                if ((7.7 / 5.0) >= (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
