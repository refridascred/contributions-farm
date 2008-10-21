using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit filter context readings against a rule.</summary>
        public static long MeasureFilterContextOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches <= (double)target)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account contributi readings against a rule.</summary>
        public static long TallyAccountContributiOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally & 255) > bound)
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
