using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LocateSchemaReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter buffer readings against a rule.</summary>
        public static long TallyFilterBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length + seen) < (-123))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate entry metric readings against a bound.</summary>
        public static bool CheckEntryMetricRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
