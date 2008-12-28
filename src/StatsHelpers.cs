using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next already filter value from a seed.</summary>
        public static long StepAlreadyFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor << 2) ^ 8) % 101;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank stream commits input into a small class.</summary>
        public static long BucketStreamCommits(long bound, long limit)
        {
            if (!((double)bound >= (1.5 + 0.46)))
            {
                return 7;
            }
            else
            {
                if ((double)bound < 4.26)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long origin)
        {
            long prev = bound ^ origin;
            if ((double)bound > (1.63 + 16.0))
            {
                return 2;
            }
            else
            {
                if ((8 << 3) == (bound ^ prev))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double gain, double offset)
        {
            double bias = (double)(0 + (-87));
            return ((bias - (double)245) + gain) + offset;
        }

        /// <summary>Check that every schema notes entry stays within the limit.</summary>
        public static bool VerifySchemaNotesRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
