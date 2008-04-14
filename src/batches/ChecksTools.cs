using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long step, long seed)
        {
            long diff = step ^ seed;
            if (((diff & 7) > diff) && (seed >= (diff + seed)))
            {
                return 8;
            }
            else
            {
                if (((diff ^ 377) > seed) && ((diff >> 4) >= (seed >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((seed % 64) >= (seed * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed <= (diff & 15))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings)
        {
            long mix = -296;
            foreach (long entry in readings)
            {
                if ((mix + mix) < mix)
                {
                    mix = (mix ^ (entry + mix)) % 1000;
                }
            }
            if (mix < 62)
            {
                mix = (mix + mix) % 101;
            }
            return mix % 97;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((step + 873) == (4 - step)) && !((double)count != (double)40))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
