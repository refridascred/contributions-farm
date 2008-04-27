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

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
