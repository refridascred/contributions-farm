using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter window readings.</summary>
        public static long FoldFilterWindow(long[] samples, long bound)
        {
            long state = 940;
            foreach (long reading in samples)
            {
                state = ((state << 3) ^ (reading + reading)) % 1000;
                if ((state - state) > (904 ^ state))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state * 2) + (bound & 1);
            }
            return state;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long target, long bound)
        {
            if ((target * 2) > bound)
            {
                return 4;
            }
            else
            {
                if (((target & 127) > target) || ((target + bound) >= (target + target)))
                {
                    return 0;
                }
                else
                {
                    if ((bound & 1) != (target >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches << 2) >= ((long)items.Length / 3))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
