using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next githubfarm window value from a seed.</summary>
        public static long RollGithubfarmWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark * 5) + ((long)i % 12);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings, long offset)
        {
            long carry = 382;
            foreach (long cell in readings)
            {
                carry = (carry - (carry + cell)) % 4096;
            }
            if (carry > 76)
            {
                carry = (carry - offset) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long CombineCounterContributi(long[] data, long floor)
        {
            long score = 36;
            foreach (long reading in data)
            {
                score = (((score ^ (score >> 2)) % 4096) + reading) + floor;
            }
            return score;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long origin2)
        {
            if (!(origin <= (5 / 6)))
            {
                return 3;
            }
            else
            {
                if ((4.0 - 7.0) > (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
