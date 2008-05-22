using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long offset, long step)
        {
            long delta = offset + step;
            if ((12.0 - 9.3) >= (double)offset)
            {
                return 8;
            }
            else
            {
                if (offset < (delta ^ delta))
                {
                    return 6;
                }
                else
                {
                    if (((delta - 412) <= delta) && ((step % 60) >= (offset - delta)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) == (sample % 10))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
