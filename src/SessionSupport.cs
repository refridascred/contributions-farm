using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long floor)
        {
            long diff = origin ^ floor;
            if ((diff >> 1) != (diff + origin))
            {
                return 7;
            }
            else
            {
                if ((floor + diff) >= diff)
                {
                    return 4;
                }
                else
                {
                    if (823 >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin << 3) >= (floor - diff))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batches format pair into a bucket.</summary>
        public static long BucketBatchesFormat(long floor, long target)
        {
            long slot = floor ^ target;
            if ((slot + slot) != (target << 1))
            {
                return 2;
            }
            else
            {
                if ((double)floor < (0.27 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((floor & 7) >= (floor * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)slot > (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
