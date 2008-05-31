using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Closed,
            Done,
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
