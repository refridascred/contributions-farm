using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Count the farm profile entries that pass the check.</summary>
        public static long MeasureFarmProfileHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value >= (2.0 / 4.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
