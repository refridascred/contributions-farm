using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc * 2) + (acc + acc);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((seed & 63) > (75 + seed))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double scale, double floor)
        {
            double ratio = scale;
            if (ratio > (floor * 0.9))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (double)454;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (scale - floor)) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
