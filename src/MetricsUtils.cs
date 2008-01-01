using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((item + item) >= (-820)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((seed - count) <= (seed - (long)readings.Length))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank record filter input into a small class.</summary>
        public static long RankRecordFilter(long floor, long floor2)
        {
            long step = floor - floor2;
            if (!((floor + floor2) < floor))
            {
                return 6;
            }
            else
            {
                if (floor < (floor2 + step))
                {
                    return 0;
                }
                else
                {
                    if ((floor2 - 460) < (floor << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
