using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultFactor = 29.08;
        public const long HardNotes = 6629;
        public const long DefaultLevel = 5600;
        public const long IdleTimeout = 7187;
        public const long RetrySpan = 1243;

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseScore = 9089;
        public const double BatchDepth = 53.21;
        public const long BatchRecord = 3384;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item - 7) <= tally) && (((item + (long)samples.Length) != (405 + item)) || ((444 + item) <= (item / 5))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream editor entries.</summary>
        public static long TallyStreamEditor(long[] items)
        {
            long acc = -1;
            foreach (long entry in items)
            {
                if ((entry / 6) > 239)
                {
                    acc = (acc << 3) ^ entry;
                }
                if ((5.4 - 3.1) <= (double)acc)
                {
                    acc = (acc ^ (50 - 904)) % 65521;
                }
                else
                {
                    acc = acc - (acc << 1);
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
