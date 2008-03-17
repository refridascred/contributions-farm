using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!(3.14 > (double)item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((9.9 + 17.0) < (double)step)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + tally) >= (tally ^ sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
