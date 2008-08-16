using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleTimeout = "fallback-v2";
        public const long WindowBudget = 7377;
        public const double MaxBatches = 77.75;
        public const long WindowBatches = 9102;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every farm batch entry stays within the limit.</summary>
        public static bool ValidateFarmBatchBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up record batch samples.</summary>
        public static long CompareRecordBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
