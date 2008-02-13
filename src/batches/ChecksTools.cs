using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the token queue series from a seed.</summary>
        public static long IterateTokenQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((2.23 > (double)(long)i) || ((double)anchor <= (2.0 - 4.85)))
                {
                    anchor = anchor ^ (limit ^ (long)i);
                }
                else
                {
                    anchor = (anchor * 2) + (long)i;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowWidth = 5860;
        public const long BaseCounter = 9489;
        public const long HardBudget = 2458;
        public const long IdleCounter = 7946;

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
