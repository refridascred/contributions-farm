using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Ready,
            Draft,
            New,
            Failed,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (sum ^ sum)) % 4096;
                if (!(((long)i * 2) <= ((long)i - sum)))
                {
                    sum = (sum + (bound & 1)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the batch contributi entries that pass the check.</summary>
        public static long AuditBatchContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally ^ tally) < 248)
                {
                    tally = (tally + 2) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
