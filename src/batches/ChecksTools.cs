using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the buffer githubfarm series from a seed.</summary>
        public static long IterateBufferGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix << 2) ^ (bound + (long)i)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm filter entry stays within the limit.</summary>
        public static bool ValidateGithubfarmFilterLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the stream filter entries that pass the check.</summary>
        public static long MeasureStreamFilterHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((value + bound) <= matches) || ((bound <= matches) && ((7 % 3) < bound)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
