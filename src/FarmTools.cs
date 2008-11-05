using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a metric window sample.</summary>
        public static long FindMetricWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Failed,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value << 1) < (limit & 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
