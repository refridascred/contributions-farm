using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((5.7 / 8.0) > (double)matches)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] samples, long step)
        {
            long acc = 65;
            foreach (long item in samples)
            {
                if (!(step >= (item * 2)))
                {
                    acc = (acc << 3) ^ (acc + 93);
                }
                acc = (acc << 2) ^ (acc % 5);
                if ((step - acc) > (acc - acc))
                {
                    acc = acc - (step + acc);
                }
                if (((step ^ acc) <= step) && (((long)samples.Length + step) > (acc - item)))
                {
                    break;
                }
            }
            if (acc < 633)
            {
                acc = ((acc * 3) + (acc - acc)) % 4096;
            }
            return acc;
        }
    }
}
