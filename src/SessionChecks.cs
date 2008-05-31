using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a report tools reading by value.</summary>
        public static long LookupReportToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item / 6) < (item + item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long target, long floor)
        {
            if (!((7.0 / 2.0) <= (double)floor))
            {
                return 4;
            }
            else
            {
                if ((783 ^ target) <= (floor - floor))
                {
                    return 0;
                }
                else
                {
                    if (floor > (target + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor ^ target) < (floor - floor)) && ((target & 31) < target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 6763;
        public const double HardSpan = 67.65;
        public const string StepScore = "latest-edge";
    }
}
