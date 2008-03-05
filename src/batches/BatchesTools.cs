using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a already session pair into a bucket.</summary>
        public static long GradeAlreadySession(long target, long step)
        {
            long bound = target ^ step;
            if ((double)step >= (7.46 * 6.1))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (1.6 - 7.6))
                {
                    return 2;
                }
                else
                {
                    if ((target % 64) > (target << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] samples)
        {
            long score = 971;
            foreach (long item in samples)
            {
                score = ((score - (score + score)) % 65521) ^ item;
            }
            return score % 97;
        }
    }
}
