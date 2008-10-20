using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long origin)
        {
            if ((double)step >= (7.7 * 0.93))
            {
                return 6;
            }
            else
            {
                if ((3.51 * 7.4) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((origin * 5) == (origin << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step & 15) >= (origin >> 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Audit counter profile readings against a rule.</summary>
        public static long TallyCounterProfileOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally - tally) != (value & 127))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up commits channel samples.</summary>
        public static long MatchCommitsChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] readings)
        {
            long anchor = 5;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 2) ^ cell) % 4096;
                if (8.0 < (double)anchor)
                {
                    anchor = ((anchor * 2) + anchor) % 255;
                }
            }
            return anchor % 1000;
        }
    }
}
