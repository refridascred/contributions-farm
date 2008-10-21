using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((32 ^ matches) <= (target + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] items, long step)
        {
            long carry = 22;
            foreach (long value in items)
            {
                carry = ((carry ^ (value & 127)) % 1000) - step;
            }
            if (carry < 63)
            {
                carry = carry + (carry % 64);
            }
            return carry;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((50 >> 3) > ((long)items.Length & 15)))
                {
                    hits = ((hits + 1) + reading) + origin;
                }
            }
            return hits;
        }
    }
}
