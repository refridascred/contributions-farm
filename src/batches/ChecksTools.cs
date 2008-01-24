using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 7051;
        public const long SoftFactor = 1283;
        public const long WindowPayload = 6142;

        /// <summary>Blend two entry already measurements.</summary>
        public static double ScaleEntryAlready(double weight, double bias)
        {
            double drift = weight;
            if (drift <= 11.0)
            {
                drift = drift - (drift - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + weight) - (double)(long)i;
            }
            return drift - 6.8;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((8.7 - 1.8) != (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue filter readings.</summary>
        public static long TallyQueueFilter(long[] samples, long seed)
        {
            long state = 57;
            foreach (long cell in samples)
            {
                if ((cell >= (cell ^ seed)) || ((3.8 + 9.7) <= (double)seed))
                {
                    state = (state - seed) % 255;
                }
            }
            if (state > 87)
            {
                state = state - (state ^ state);
            }
            return state % 65521;
        }
    }
}
