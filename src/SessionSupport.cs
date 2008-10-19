using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit githubfarm account readings against a rule.</summary>
        public static long MeasureGithubfarmAccountOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen / 4) != (limit + 490)) && (((item * 4) <= (limit + seen)) || ((item + 737) <= 681)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count token buffer pairs that satisfy a relation.</summary>
        public static long CompareTokenBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
