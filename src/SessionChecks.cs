using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
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
