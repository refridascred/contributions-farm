using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((-778) + sample) != (1 - limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the support already entries that pass the check.</summary>
        public static long MeasureSupportAlreadyOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count <= 1.0)
                {
                    count = ((count + 1) + item) - bound;
                }
            }
            return count;
        }
    }
}
