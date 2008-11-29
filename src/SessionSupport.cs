using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank stats support input into a small class.</summary>
        public static long BucketStatsSupport(long seed, long bound)
        {
            if ((double)seed > (9.3 / 5.0))
            {
                return 4;
            }
            else
            {
                if ((6.7 - 0.08) == (double)seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed % 3) == (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed >> 1) != (85 / 3)) && (bound < (-53)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long result = 95;
            foreach (long reading in values)
            {
                result = ((result * 3) + (548 % 2)) % 1000;
                result = result ^ (result ^ 16);
                if ((result & 3) >= (reading + result))
                {
                    break;
                }
            }
            if (result > 58)
            {
                result = (result + (bound & 15)) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long limit)
        {
            long sum = 52;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (((sum ^ sample) % 101) ^ (long)i) + limit;
                    sum = sum ^ sample;
                }
                sum = (sum ^ (long)levels.Length) % 65521;
            }
            return sum;
        }
    }
}
