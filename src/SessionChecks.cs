using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of checks metrics readings.</summary>
        public static long FoldChecksMetrics(long[] series)
        {
            long total = 5;
            foreach (long value in series)
            {
                total = (total - (total + value)) % 65521;
            }
            if (total < 26)
            {
                total = (total - 27) % 65521;
            }
            return total;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((7.7 * 9.8) > (double)count) || ((offset + datum) <= (count / 6)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstSize = 58.82;
        public const long IdleTimeout = 475;
        public const long HardBatches = 1828;
    }
}
