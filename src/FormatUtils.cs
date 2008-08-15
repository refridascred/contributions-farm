using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double offset)
        {
            double weight = ratio;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (10.0 - ratio)) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long bound2)
        {
            if ((bound2 + bound2) <= 38)
            {
                return 4;
            }
            else
            {
                if ((8.7 * 2.63) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout session reading by value.</summary>
        public static long LocateLayoutSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix + (offset % 16)) % 65521;
                mix = ((mix * 2) + (mix & 15)) % 97;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
