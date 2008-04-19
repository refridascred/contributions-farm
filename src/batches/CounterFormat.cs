using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples, long bound)
        {
            long carry = 547;
            foreach (long sample in samples)
            {
                carry = ((carry << 3) ^ (bound - bound)) % 97;
                carry = (carry ^ (sample % 24)) % 255;
            }
            return carry;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items)
        {
            long anchor = -35;
            foreach (long entry in items)
            {
                if ((6.4 * 2.0) > (double)anchor)
                {
                    anchor = ((anchor << 2) ^ entry) % 97;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor - (anchor >> 4)) % 1000;
            }
            return anchor;
        }
    }
}
