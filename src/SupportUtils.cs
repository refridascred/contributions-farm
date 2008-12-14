using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long target)
        {
            if (6.54 >= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed > (3.54 / 2.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((double)seed < (14.0 / 9.0))
                {
                    sum = (sum - (51 / 2)) % 1000;
                    continue;
                }
                if (seed >= sum)
                {
                    sum = (sum ^ sum) % 4096;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
