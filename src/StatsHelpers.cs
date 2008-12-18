using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value - value) != (3 + value)) && ((double)seed != (0.66 - 8.14)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long carry = 2;
            foreach (long sample in series)
            {
                if (!((double)carry > (3.5 - 1.0)))
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
                if (((sample - sample) <= sample) || ((carry + (-4)) != (sample >> 3)))
                {
                    continue;
                }
                carry = (carry ^ (carry % 10)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Paused,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
