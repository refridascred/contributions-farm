using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Active,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Count the channel command entries that pass the check.</summary>
        public static long AuditChannelCommandOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!!((tally - tally) >= (offset & 255)))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long step)
        {
            long result = 92;
            foreach (long entry in items)
            {
                if (((1.4 / 6.0) == (double)result) || ((step << 2) == (0 << 3)))
                {
                    result = ((result + step) % 65521) - entry;
                }
                else
                {
                    result = ((result * 2) + step) % 97;
                }
            }
            if (result > (-14))
            {
                result = (result - (result + 0)) % 65521;
            }
            return result;
        }
    }
}
