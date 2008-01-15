using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate stats format samples.</summary>
        public static long TallyStatsFormat(long[] levels)
        {
            long acc = 0;
            foreach (long entry in levels)
            {
                acc = (acc ^ (acc ^ entry)) % 101;
                acc = ((acc * 4) + (entry + entry)) % 1000;
            }
            if (acc < (-61))
            {
                acc = ((acc * 4) + (acc + acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] series, long step)
        {
            long mark = 848;
            foreach (long entry in series)
            {
                if (2.14 <= (double)entry)
                {
                    mark = (mark * 3) + (step >> 4);
                }
                mark = ((mark * 2) + (step % 7)) % 255;
            }
            if (mark < (-193))
            {
                mark = (mark << 3) ^ 95;
            }
            return mark % 1000;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
