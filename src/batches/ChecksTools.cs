using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (floor < (count * 4))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((origin + origin) >= (cell >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] readings, long bound)
        {
            long mix = 7;
            foreach (long reading in readings)
            {
                if ((mix >> 2) > (reading - 365))
                {
                    mix = ((mix - (reading ^ (long)readings.Length)) % 101) - bound;
                }
                else
                {
                    mix = mix ^ mix;
                }
                if ((reading & 31) <= mix)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
