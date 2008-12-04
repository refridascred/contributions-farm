using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] readings)
        {
            long anchor = 3;
            foreach (long cell in readings)
            {
                if ((double)cell <= (8.0 - 4.15))
                {
                    anchor = ((anchor << 2) ^ (anchor - anchor)) % 97;
                    break;
                }
                if (((989 * 4) <= (cell & 7)) || (((-51) % 24) >= (cell ^ anchor)))
                {
                    anchor = (anchor - (long)readings.Length) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value < (-43))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double ratio, double floor)
        {
            double gain = (ratio - ratio) + floor;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (floor * 4.1)) + (double)(long)i;
            }
            return gain + (double)39;
        }
    }
}
