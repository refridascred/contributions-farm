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

        /// <summary>Audit checks route readings against a rule.</summary>
        public static long AuditChecksRouteHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)entry < 1.0) && ((entry - entry) > 7))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }
    }
}
