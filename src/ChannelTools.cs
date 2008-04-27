using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Accumulate window order samples.</summary>
        public static long FoldWindowOrder(long[] series)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if (((cell % 8) <= (272 & 15)) || ((3.0 / 5.0) > (double)mark))
                {
                    mark = (mark << 3) ^ (mark + 8);
                }
            }
            return mark;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings, long floor)
        {
            long anchor = 1;
            foreach (long entry in readings)
            {
                anchor = (((anchor ^ (anchor ^ (long)readings.Length)) % 4096) ^ entry) + floor;
            }
            return anchor;
        }
    }
}
