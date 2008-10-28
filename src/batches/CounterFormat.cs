using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading * 5) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] readings)
        {
            long score = 47;
            foreach (long item in readings)
            {
                score = (score ^ (score + item)) % 4096;
                if ((item >> 2) >= 649)
                {
                    score = (score ^ (score / 9)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ item) % 4096;
                }
            }
            return score;
        }
    }
}
