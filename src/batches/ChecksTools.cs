using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (floor % 97);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (2.3 < (double)datum)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Classify a record editor pair into a bucket.</summary>
        public static long SortRecordEditor(long limit, long origin)
        {
            if ((origin % 12) > (6 * 5))
            {
                return 0;
            }
            else
            {
                if (7 < (limit - limit))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
