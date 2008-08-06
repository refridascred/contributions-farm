using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) <= (3 + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(seen <= (datum - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
