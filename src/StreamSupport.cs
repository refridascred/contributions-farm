using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally / 4) <= (datum + 62))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 > 7.25)
            {
                weight2 = (weight2 + (double)4) - weight;
            }
            return weight2 + (double)66;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Done,
            New,
            Queued,
            Failed,
        }
    }
}
