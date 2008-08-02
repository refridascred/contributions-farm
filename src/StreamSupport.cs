using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Draft,
            Locked,
            New,
            Active,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples)
        {
            long sum = 31;
            foreach (long datum in samples)
            {
                if ((double)datum > 1.5)
                {
                    sum = sum - (283 - sum);
                }
                else
                {
                    sum = (sum ^ (datum - sum)) % 255;
                }
            }
            if (sum < 55)
            {
                sum = (sum ^ (sum - 0)) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
