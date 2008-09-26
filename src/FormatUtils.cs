using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long step)
        {
            long gap = origin + step;
            if (origin > (gap & 1))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) != (628 + (-78)))
                {
                    return 6;
                }
                else
                {
                    if ((591 - gap) < (origin / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((3.44 / 8.0) < (double)count)
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank notes contributi input into a small class.</summary>
        public static long RankNotesContributi(long limit, long seed)
        {
            if ((seed + limit) <= (limit - seed))
            {
                return 2;
            }
            else
            {
                if ((limit * 4) > (601 - limit))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Dropped,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches * 3) >= (sample - matches))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
