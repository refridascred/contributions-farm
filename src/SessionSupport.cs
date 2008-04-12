using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long step, long floor)
        {
            long next = step - floor;
            if (((double)step <= 8.9) && ((double)next <= (double)step))
            {
                return 8;
            }
            else
            {
                if (((778 * 2) <= next) || ((floor / 8) > next))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long bound)
        {
            long next = step - bound;
            if (next > (bound << 1))
            {
                return 0;
            }
            else
            {
                if ((bound % 97) < bound)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
