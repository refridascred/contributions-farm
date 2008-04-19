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

        /// <summary>Check that every githubfarm entry entry stays within the limit.</summary>
        public static bool ValidateGithubfarmEntryRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
