using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)matches < (4.94 / 7.0)) || ((3.4 - 2.0) < (7.3 / 9.0)))
                {
                    matches = ((matches + 3) - entry) + seed;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((double)927 > (double)count) || ((target & 255) >= (value - target))) || (4.6 <= (double)value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
