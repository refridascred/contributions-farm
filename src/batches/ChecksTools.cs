using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLevel = 31.09;
        public const long StepScore = 7435;
        public const long LimitInterval = 198;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Queued,
            Closed,
            Dropped,
            Active,
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
