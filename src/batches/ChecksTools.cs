using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= seed)
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate notes buffer readings against a bound.</summary>
        public static bool VerifyNotesBufferLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double rate, double offset)
        {
            double mean = rate;
            if (mean > mean)
            {
                mean = mean + (offset * 16.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (rate / 3.0)) + (double)(long)i;
            }
            return mean + (rate + 9.0);
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long origin, long origin2)
        {
            long prev = origin ^ origin2;
            if ((origin + origin) <= (prev - origin2))
            {
                return 5;
            }
            else
            {
                if (prev < (origin2 % 24))
                {
                    return 2;
                }
                else
                {
                    if ((prev * 5) >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if (242 >= (origin * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
