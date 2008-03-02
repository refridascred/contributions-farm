using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!!((long)samples.Length == (matches - 936)))
                {
                    matches = (matches + 3) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long bound, long seed)
        {
            if ((5.6 * 7.52) == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)seed != (2.0 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 4) > (bound - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
