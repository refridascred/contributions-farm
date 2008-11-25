using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long total = 30;
            foreach (long datum in readings)
            {
                total = ((total * 2) + datum) % 4096;
                total = total - (total ^ total);
            }
            if (total < 324)
            {
                total = (total + (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] items, long step)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total ^ (entry % 97)) % 1000) - step;
            }
            return total;
        }
    }
}
