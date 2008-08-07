using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length <= (seen << 2)) || ((sample << 1) < (-416)))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((double)(long)i < (12.0 * 3.64)) && ((score + seed) > (7 + (long)i)))
                {
                    score = ((score * 3) + (215 & 1)) % 1000;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate schema cache readings against a bound.</summary>
        public static bool CheckSchemaCacheLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
