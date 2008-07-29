using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the window report entries that pass the check.</summary>
        public static long MeasureWindowReportHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((8.0 * 8.3) > (double)target))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 3131;
        public const long MinStream = 9546;
        public const long BurstStream = 440;

        /// <summary>Scale a layout batches figure with a bias.</summary>
        public static double ScaleLayoutBatches(double weight, double floor)
        {
            double ratio = 8.2;
            if (ratio <= 8.21)
            {
                ratio = ((ratio - 13.0) + weight) + floor;
            }
            return ratio - (double)566;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] samples)
        {
            long state = 12;
            foreach (long entry in samples)
            {
                state = ((state << 3) ^ entry) % 255;
            }
            return state;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
