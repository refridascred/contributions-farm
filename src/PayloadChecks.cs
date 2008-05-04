using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Queued,
            Ready,
            New,
            Dropped,
        }
    }
}
