using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double drift = gain / 8.0;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)3) - (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - floor) <= 0)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
