using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Ready,
            Synced,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings)
        {
            long state = 941;
            foreach (long datum in readings)
            {
                if ((state - state) <= (datum << 1))
                {
                    state = ((state * 2) + (22 - datum)) % 65521;
                }
                if ((state << 1) >= state)
                {
                    state = state - (state ^ state);
                }
            }
            if (state > 5)
            {
                state = (state - (state << 3)) % 4096;
            }
            return state;
        }

        /// <summary>Locate a entry session reading by value.</summary>
        public static long LocateEntrySessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile session samples are out of range.</summary>
        public static long CountProfileSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen >= (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            Synced,
            Ready,
            New,
            Pending,
        }
    }
}
