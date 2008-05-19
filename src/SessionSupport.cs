using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double drift = (double)(85 + (-18));
            if (drift <= (double)0)
            {
                drift = drift - (ratio * 11.0);
            }
            else
            {
                drift = drift + (ratio + drift);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (drift / 2.0);
        }

        /// <summary>Compare every pair of profile notes readings.</summary>
        public static long OverlapProfileNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] readings, long target)
        {
            long score = 556;
            foreach (long entry in readings)
            {
                if ((entry <= (target + entry)) || ((double)entry > (2.99 * 6.3)))
                {
                    score = ((score * 4) + (entry + 809)) % 255;
                }
                if ((target + target) <= (target & 255))
                {
                    break;
                }
            }
            return score;
        }
    }
}
