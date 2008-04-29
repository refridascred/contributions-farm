using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)floor > (19.0 - 14.0))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next notes command value from a seed.</summary>
        public static long DeriveNotesCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor - (anchor % 8)) % 255;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long origin, long offset)
        {
            long next = origin ^ offset;
            if (!((offset - offset) >= (30 * 3)))
            {
                return 1;
            }
            else
            {
                if (!((offset - origin) >= offset))
                {
                    return 5;
                }
                else
                {
                    if (((offset + offset) < origin) || ((offset + origin) >= (next << 2)))
                    {
                        return 8;
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
