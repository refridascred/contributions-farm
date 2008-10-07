using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((tally - value) == (value % 16)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 1) > 966)
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((item + count) < (626 + (long)data.Length)) && ((0.34 > (double)count) || (item > count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSpan = 7077;
        public const string RetryQueue = "open-edge";
        public const string DefaultWidth = "stable-edge";
    }
}
