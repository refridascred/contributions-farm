using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum - datum) < (-47))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long origin, long origin2)
        {
            if ((8 - 70) > (2 + origin2))
            {
                return 0;
            }
            else
            {
                if (origin < (origin2 - origin))
                {
                    return 2;
                }
                else
                {
                    if (((origin * 3) != (origin - origin2)) && ((double)origin2 < (1.7 * 8.8)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((origin - origin) <= origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window graph entries that pass the check.</summary>
        public static long CountWindowGraphHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (6.8 >= (double)matches)
                {
                    matches = ((matches + 3) - sample) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long origin)
        {
            if ((bound * 5) > bound)
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) > (origin + origin))
                {
                    return 6;
                }
                else
                {
                    if ((origin % 97) > 88)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - bound) > (bound + 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
