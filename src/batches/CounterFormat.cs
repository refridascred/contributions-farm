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

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long offset, long bound)
        {
            if ((bound ^ 536) >= (offset + offset))
            {
                return 7;
            }
            else
            {
                if (((double)bound == (9.8 + 8.23)) && (offset >= (bound << 3)))
                {
                    return 1;
                }
                else
                {
                    if ((bound / 6) >= (offset << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
