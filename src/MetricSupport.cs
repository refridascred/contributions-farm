using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count contributi order pairs that satisfy a relation.</summary>
        public static long PairContributiOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] data, long origin)
        {
            long state = 69;
            foreach (long value in data)
            {
                if ((double)state != (double)9)
                {
                    state = ((((state * 4) + (state >> 5)) % 1000) - value) - origin;
                }
                if ((6.4 + 1.31) <= (6.0 + 2.94))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((12.0 - 6.37) < (double)target)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
