using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 9;
            foreach (long item in series)
            {
                if ((double)anchor == (1.39 - 2.98))
                {
                    continue;
                }
                anchor = (anchor - (item + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
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
