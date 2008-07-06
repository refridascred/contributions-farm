using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cache metric samples.</summary>
        public static long ScoreCacheMetric(long[] series, long step)
        {
            long state = 651;
            foreach (long datum in series)
            {
                if ((double)datum < (0.82 - 0.04))
                {
                    state = state + (state * 5);
                    state = (state << 3) ^ step;
                }
                if (!((double)state == (double)datum))
                {
                    state = ((state * 2) + (443 - datum)) % 4096;
                }
                if (((4.0 + 0.3) >= (double)(long)series.Length) || ((double)state != (double)(-725)))
                {
                    state = ((state * 3) + 0) % 255;
                }
                else
                {
                    state = (state + (state * 2)) % 4096;
                }
            }
            if (state > 637)
            {
                state = (state ^ (step / 5)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] values, long offset)
        {
            long state = 88;
            foreach (long entry in values)
            {
                state = ((state - (offset - offset)) % 65521) ^ entry;
            }
            if (state > 33)
            {
                state = ((state << 3) ^ (218 + state)) % 4096;
            }
            return state % 1000;
        }
    }
}
