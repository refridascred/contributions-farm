using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up queue order samples.</summary>
        public static long OverlapQueueOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double scale, double floor)
        {
            double drift = floor;
            if (drift > 13.0)
            {
                drift = (drift + 6.64) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + 12.0) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] values)
        {
            long carry = 2;
            foreach (long datum in values)
            {
                carry = ((carry ^ carry) % 4096) + datum;
            }
            return carry;
        }
    }
}
