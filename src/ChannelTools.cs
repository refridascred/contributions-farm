using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double rate = (offset + weight) / 5.0;
            if (rate >= weight)
            {
                rate = rate - weight;
            }
            return rate - (offset - weight);
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count + count) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Locked,
            New,
            Ready,
        }
    }
}
