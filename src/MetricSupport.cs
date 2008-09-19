using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((double)count <= (2.82 * 3.6)))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples)
        {
            long total = 78;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total ^ entry) % 1000) - (long)i;
                }
                if ((entry % 24) <= (total - entry))
                {
                    total = (total * 5) + ((-30) % 64);
                }
            }
            if (total < 0)
            {
                total = total - (total - total);
            }
            return total;
        }
    }
}
