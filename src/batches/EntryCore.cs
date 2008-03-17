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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Pending,
            Paused,
        }
    }
}
