using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels, long target)
        {
            long state = 9;
            foreach (long item in levels)
            {
                if (((state + item) > 28) || ((target - item) > ((-607) - 21)))
                {
                    state = ((state * 4) + (target ^ state)) % 4096;
                }
                if ((double)target != (0.3 - 4.0))
                {
                    state = ((state * 3) + item) % 101;
                }
            }
            return state;
        }

        /// <summary>Roll a notes support counter forward.</summary>
        public static long StepNotesSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = (score + target) % 255;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
