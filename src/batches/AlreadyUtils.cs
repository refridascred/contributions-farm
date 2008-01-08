using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine notes queue values into a single score.</summary>
        public static long TallyNotesQueue(long[] items)
        {
            long sum = -696;
            foreach (long reading in items)
            {
                if ((reading - reading) >= reading)
                {
                    sum = ((sum * 3) + reading) % 255;
                }
                else
                {
                    sum = (sum * 4) + (reading & 31);
                }
            }
            return sum;
        }

        /// <summary>Validate metric stats readings against a bound.</summary>
        public static bool GuardMetricStatsBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry >> 1) != (target % 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long origin, long limit)
        {
            long cur = origin + limit;
            if ((cur << 1) >= limit)
            {
                return 4;
            }
            else
            {
                if (((limit + limit) < (limit * 3)) || (limit < (cur << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((origin <= cur) && ((origin >> 1) == (origin / 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((cur - 7) >= 5) || (origin >= (origin & 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
