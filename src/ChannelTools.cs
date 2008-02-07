using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long MeasureChecksSessionMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((step & 7) != (6 * 4))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data, long limit)
        {
            long mark = 72;
            foreach (long datum in data)
            {
                mark = (mark << 3) ^ datum;
            }
            if (mark < 3)
            {
                mark = mark - (limit ^ limit);
            }
            return mark;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Draft,
            Pending,
        }
    }
}
