using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next tools context value from a seed.</summary>
        public static long RollToolsContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if (152 >= offset)
                {
                    sum = ((sum << 2) ^ (sum << 1)) % 97;
                }
                if ((sum % 16) > (229 >> 2))
                {
                    long diff = 6;
                    sum = sum ^ diff;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
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
