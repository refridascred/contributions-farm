using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double gain, double floor)
        {
            double weight = (double)(175 ^ (-80));
            return ((weight + 3.03) + gain) + floor;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long origin, long target)
        {
            long slot = origin - target;
            if (((slot * 2) > (origin * 5)) || ((origin % 3) <= target))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (15.0 * 13.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data, long limit)
        {
            long state = 162;
            foreach (long entry in data)
            {
                if (((double)state <= (3.1 / 7.0)) || ((double)entry == (7.6 * 8.1)))
                {
                    state = (state - (limit + limit)) % 4096;
                }
                else
                {
                    state = (state << 3) ^ (7 ^ entry);
                }
                state = (state - (95 ^ state)) % 101;
                if ((double)limit < (double)entry)
                {
                    state = ((state << 2) ^ (limit - entry)) % 1000;
                }
            }
            return state;
        }
    }
}
