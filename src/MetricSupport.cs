using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels, long origin)
        {
            long anchor = 391;
            foreach (long value in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor - (value ^ anchor)) ^ (long)i;
                    anchor = ((anchor << 3) ^ (value - anchor)) % 255;
                }
                if ((double)anchor > (16.0 + 7.0))
                {
                    anchor = ((anchor * 3) + (anchor ^ origin)) % 65521;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            if (anchor > 639)
            {
                anchor = (anchor + (anchor - anchor)) % 97;
            }
            return anchor;
        }
    }
}
