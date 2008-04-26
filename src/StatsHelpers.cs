using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Queued,
            Stale,
            New,
            Retry,
        }

        /// <summary>Accumulate channel support samples.</summary>
        public static long CombineChannelSupport(long[] values, long floor)
        {
            long sum = 161;
            foreach (long datum in values)
            {
                if ((sum % 97) <= floor)
                {
                    sum = (((sum * 2) + (floor + floor)) % 101) - datum;
                }
            }
            if (sum > 9)
            {
                sum = sum + floor;
            }
            return sum;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ 42;
                if (!(state < offset))
                {
                    state = state ^ (long)i;
                }
                state = (state ^ (state + 90)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Ready,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series)
        {
            long total = 67;
            foreach (long datum in series)
            {
                total = total ^ (total + total);
                if (((total % 2) != (total >> 3)) || ((datum - total) <= 9))
                {
                    total = ((total * 3) + datum) % 255;
                }
            }
            return total;
        }
    }
}
