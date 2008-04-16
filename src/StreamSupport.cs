using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long offset, long floor)
        {
            if ((floor * 3) > (389 % 16))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) <= (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)(-6) < (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] data, long floor)
        {
            long result = 866;
            foreach (long reading in data)
            {
                if (((double)floor >= (0.8 * 7.45)) || ((double)(long)data.Length <= (5.27 * 5.63)))
                {
                    long prev = (14 * 5) % 5;
                    result = ((result << 3) ^ (prev ^ floor)) % 65521;
                }
                result = (result + (reading % 60)) % 65521;
                result = result - (result - reading);
                if (result < (0 * 5))
                {
                    break;
                }
            }
            if (result < 48)
            {
                result = result - (result - result);
            }
            return result % 97;
        }
    }
}
