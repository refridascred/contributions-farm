using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double ratio, double floor)
        {
            double load = floor;
            if (load < floor)
            {
                load = (load - (double)46) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 3.0) + (double)(long)i;
            }
            return load + (8.5 / 8.0);
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading <= (reading - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
