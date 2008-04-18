using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long floor)
        {
            long edge = offset ^ floor;
            if (offset < edge)
            {
                return 8;
            }
            else
            {
                if (((-9) >> 2) > (edge + offset))
                {
                    return 1;
                }
                else
                {
                    if ((0 * 5) <= (85 + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (edge < (offset * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((0 % 8) != (offset << 3))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile githubfarm value from a seed.</summary>
        public static long StepProfileGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (long)i) % 1000;
                if (((double)offset < (0.86 - 1.0)) && ((653 + result) <= offset))
                {
                    result = (result - (offset % 24)) % 101;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] series, long bound)
        {
            long mark = 564;
            foreach (long item in series)
            {
                if (!(((long)series.Length << 1) == (bound - (long)series.Length)))
                {
                    mark = (((mark << 3) ^ (mark << 1)) % 97) - item;
                }
                else
                {
                    mark = (mark ^ (bound + 12)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches << 3) < (sample * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
