using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Synced,
            Closed,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] samples)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                if ((double)entry > (7.09 * 20.0))
                {
                    acc = (acc + (5 << 2)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc + entry)) % 101;
                }
            }
            if (acc > 1)
            {
                acc = acc - (acc & 63);
            }
            return acc % 65521;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double scale = (bias * 2.3) - (5.3 / 7.0);
            return (scale - (double)99) + offset;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Closed,
            Active,
            Done,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((66 - origin) != (8 + reading)) || ((reading & 63) >= (tally ^ origin)))
                {
                    tally = tally + 2;
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
