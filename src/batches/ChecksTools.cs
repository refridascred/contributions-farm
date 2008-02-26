using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((value - bound) <= value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first profile schema entry that matches the target.</summary>
        public static long LookupProfileSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Retry,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Grade a filter batch value against two limits.</summary>
        public static long RankFilterBatch(long bound, long target)
        {
            if (((target % 3) < (232 + target)) || ((double)9 < (double)target))
            {
                return 2;
            }
            else
            {
                if ((211 <= (79 ^ bound)) || ((bound ^ bound) >= (target ^ target)))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 6) > (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
