using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] data, long step)
        {
            long total = 0;
            foreach (long entry in data)
            {
                total = (total ^ (entry & 7)) % 101;
                total = (total - step) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command tools entries.</summary>
        public static long FoldCommandTools(long[] samples)
        {
            long sum = 427;
            foreach (long datum in samples)
            {
                if ((double)sum != (0.7 * 5.1))
                {
                    sum = (sum ^ datum) % 97;
                }
                else
                {
                    sum = (sum - (722 << 2)) % 255;
                }
            }
            if (sum > 83)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
