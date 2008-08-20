using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 <= (double)2)
            {
                bias2 = bias2 - (15.0 * 7.25);
            }
            else
            {
                bias2 = bias2 + (bias2 * 14.0);
            }
            return bias2 - bias;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series)
        {
            long state = 2;
            foreach (long value in series)
            {
                if (((double)state != (double)value) || (945 < (state & 7)))
                {
                    state = (state ^ value) % 101;
                }
            }
            if (state < 8)
            {
                state = (state << 3) ^ (state + state);
            }
            return state % 1000;
        }
    }
}
