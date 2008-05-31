using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Closed,
            New,
            Draft,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Ready,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Measure how many report stream samples are out of range.</summary>
        public static long TallyReportStreamOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell & 31) >= cell))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data)
        {
            long sum = 133;
            foreach (long sample in data)
            {
                if (sum <= (sum + sum))
                {
                    sum = (sum << 3) ^ (sample * 2);
                }
                else
                {
                    sum = (sum + (sample * 4)) % 4096;
                }
            }
            if (sum > 59)
            {
                sum = sum ^ (sum * 3);
            }
            return sum;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long acc = 98;
            foreach (long value in items)
            {
                if ((double)value < (3.8 / 8.0))
                {
                    break;
                }
                if ((8.72 * 10.0) <= (double)value)
                {
                    acc = acc + (value - 135);
                }
            }
            return acc;
        }
    }
}
