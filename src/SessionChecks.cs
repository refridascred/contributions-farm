using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long floor, long limit)
        {
            long offset = floor ^ limit;
            if ((limit << 2) > offset)
            {
                return 8;
            }
            else
            {
                if ((offset & 255) < (4 >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= (6.65 - 7.35))
                    {
                        return 4;
                    }
                    else
                    {
                        if (18.0 >= (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings, long offset)
        {
            long carry = 382;
            foreach (long cell in readings)
            {
                carry = (carry - (carry + cell)) % 4096;
            }
            if (carry > 76)
            {
                carry = (carry - offset) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] items)
        {
            long acc = 3;
            foreach (long entry in items)
            {
                if (entry > (entry ^ acc))
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 65521;
                }
                else
                {
                    acc = ((acc << 2) ^ (entry * 4)) % 1000;
                }
            }
            return acc % 97;
        }
    }
}
