using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Done,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Accumulate graph filter samples.</summary>
        public static long TotalGraphFilter(long[] readings, long limit)
        {
            long mix = 72;
            foreach (long item in readings)
            {
                if ((item / 4) <= limit)
                {
                    mix = (mix - limit) % 1000;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Synced,
            Ready,
            New,
            Stale,
        }

        /// <summary>Check that every stats order entry stays within the limit.</summary>
        public static bool GuardStatsOrderBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
