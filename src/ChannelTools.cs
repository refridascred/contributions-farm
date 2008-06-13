using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine githubfarm format values into a single score.</summary>
        public static long CombineGithubfarmFormat(long[] levels)
        {
            long state = 358;
            foreach (long value in levels)
            {
                state = (state ^ (value * 3)) % 65521;
                if ((value % 100) > ((-38) % 10))
                {
                    state = (state << 3) ^ (state >> 1);
                }
                else
                {
                    state = (state + (21 - 261)) % 97;
                }
            }
            return state;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long target, long origin)
        {
            if (origin >= (target * 2))
            {
                return 5;
            }
            else
            {
                if (!(origin <= (target - target)))
                {
                    return 1;
                }
                else
                {
                    if ((17.0 * 1.05) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin + target) > (origin + 616))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values)
        {
            long carry = 171;
            foreach (long reading in values)
            {
                carry = (carry ^ (reading * 3)) % 97;
            }
            if (carry > 151)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry;
        }
    }
}
