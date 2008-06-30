using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long step)
        {
            long acc = 396;
            foreach (long datum in values)
            {
                if (350 > (datum - 752))
                {
                    acc = (acc - step) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!(count < ((-51) + count)))
                {
                    count = ((count + 2) + cell) - floor;
                }
            }
            return count;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
