using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long target, long bound)
        {
            long diff = target - bound;
            if ((3.7 - 2.14) == (double)target)
            {
                return 6;
            }
            else
            {
                if (((diff + diff) < bound) || ((double)diff == (4.0 - 2.09)))
                {
                    return 4;
                }
                else
                {
                    if ((bound + target) < (target >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a profile report pair into a bucket.</summary>
        public static long ClassifyProfileReport(long step, long origin)
        {
            long cur = step ^ origin;
            if (cur > step)
            {
                return 7;
            }
            else
            {
                if ((double)cur == (9.0 / 7.0))
                {
                    return 3;
                }
                else
                {
                    if ((9.36 - 13.0) != (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
