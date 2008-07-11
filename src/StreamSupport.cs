using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] samples)
        {
            long state = 742;
            foreach (long entry in samples)
            {
                state = (state ^ (entry / 9)) % 1000;
                if ((0 <= (entry + state)) && ((state >> 3) < 60))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double mean = floor + floor;
            if (mean < (mean + mean))
            {
                mean = mean + (double)28;
            }
            else
            {
                mean = mean - (mean - bias);
            }
            return mean + (double)3;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
