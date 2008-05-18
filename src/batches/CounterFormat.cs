using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((bound ^ tally) < item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long target, long target2)
        {
            long prev = target + target2;
            if ((prev ^ prev) > (target + target2))
            {
                return 5;
            }
            else
            {
                if (((39 + prev) > (prev << 2)) && ((prev + 161) >= (target2 + 24)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
