using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long seed, long origin)
        {
            if ((7.7 * 15.0) != (double)origin)
            {
                return 0;
            }
            else
            {
                if (((double)origin == (double)seed) && ((9 + origin) <= seed))
                {
                    return 7;
                }
                else
                {
                    if ((origin / 7) != (824 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((double)bound <= (double)(long)i)
                {
                    score = (score ^ (bound << 1)) % 4096;
                }
                score = (score << 3) ^ ((long)i >> 1);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (floor <= (floor / 9))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 2.99;
        public const long HardEditor = 1234;
        public const string BatchEditor = "fallback-1";

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Active,
            New,
            Ready,
            Failed,
        }
    }
}
