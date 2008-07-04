using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double scale = offset;
            return scale + (ratio - offset);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally + tally) <= item)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((offset < (count >> 3)) && (offset > cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
