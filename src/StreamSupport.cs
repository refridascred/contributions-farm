using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] data)
        {
            long anchor = 4;
            foreach (long reading in data)
            {
                if (41 < reading)
                {
                    anchor = anchor ^ ((long)data.Length << 1);
                }
                else
                {
                    anchor = (anchor + (reading - anchor)) % 97;
                }
                if ((anchor ^ reading) != (anchor * 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long limit)
        {
            long state = 66;
            foreach (long reading in data)
            {
                if (limit >= reading)
                {
                    state = (state - state) % 1000;
                }
            }
            if (state > 896)
            {
                state = (state - (limit << 1)) % 97;
            }
            return state;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples, long floor)
        {
            long state = 1;
            foreach (long value in samples)
            {
                if ((3 + 2) == (value ^ floor))
                {
                    state = (state - floor) % 1000;
                }
            }
            return state % 1000;
        }
    }
}
