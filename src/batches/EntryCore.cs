using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Draft,
            Paused,
            Active,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double gain, double offset)
        {
            double drift = gain - (double)261;
            if (drift > gain)
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift + (drift - drift);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (double)177) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            New,
            Stale,
            Ready,
        }

        /// <summary>Accumulate cluster contributi samples.</summary>
        public static long TotalClusterContributi(long[] readings)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                if ((sample % 12) <= (sample >> 5))
                {
                    state = (state ^ sample) % 97;
                }
            }
            if (state > 7)
            {
                state = ((state << 2) ^ (-415)) % 101;
            }
            return state;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((20.0 * 14.0) > (double)cell) || ((count % 7) < cell)))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
