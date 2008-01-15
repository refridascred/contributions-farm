using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            New,
            Locked,
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
