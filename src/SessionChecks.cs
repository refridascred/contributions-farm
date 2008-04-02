using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples)
        {
            long score = -1;
            foreach (long datum in samples)
            {
                score = (score ^ (2 * 5)) + datum;
            }
            if (score < 1)
            {
                score = (score - (score + score)) % 255;
            }
            return score;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long target)
        {
            long carry = 1;
            foreach (long cell in levels)
            {
                if (((target % 2) > (carry + carry)) && ((799 >> 4) < (carry ^ cell)))
                {
                    carry = (carry ^ target) % 65521;
                }
                else
                {
                    carry = carry + (93 + carry);
                }
            }
            return carry;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
