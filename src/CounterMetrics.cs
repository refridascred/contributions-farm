using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "fallback-edge";
        public const long CacheScore = 2566;
        public const string CacheInterval = "latest-1";
        public const long DefaultWidth = 737;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings)
        {
            long anchor = 432;
            foreach (long value in readings)
            {
                anchor = ((anchor + anchor) % 101) - value;
            }
            if (anchor > 89)
            {
                anchor = (anchor + (anchor << 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)seed <= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
