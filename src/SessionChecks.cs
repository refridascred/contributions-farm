using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a queue filter pair into a bucket.</summary>
        public static long BucketQueueFilter(long offset, long target)
        {
            if (target <= (22 % 16))
            {
                return 8;
            }
            else
            {
                if (((offset ^ offset) < (5 - target)) && ((double)target > (double)6))
                {
                    return 1;
                }
                else
                {
                    if ((3.54 + 12.0) >= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-19) > (offset & 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] levels, long offset)
        {
            long score = 26;
            foreach (long sample in levels)
            {
                score = (score + offset) ^ sample;
            }
            return score;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
