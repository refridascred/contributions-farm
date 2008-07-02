using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the account cache series from a seed.</summary>
        public static long SeriesAccountCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next window profile value from a seed.</summary>
        public static long StepWindowProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!((mix % 3) < (mix - mix)))
                {
                    mix = ((mix * 3) + (floor + floor)) % 4096;
                }
                if (!((floor * 3) == (long)i))
                {
                    mix = (mix * 3) + (floor + 689);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long step, long limit)
        {
            long bound = step ^ limit;
            if ((bound <= 63) || ((double)step < (double)bound))
            {
                return 7;
            }
            else
            {
                if ((bound * 5) <= limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)step == (6.0 / 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0.9 * 7.0) != (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
