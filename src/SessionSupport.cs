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

        /// <summary>Accumulate payload filter samples.</summary>
        public static long TotalPayloadFilter(long[] levels)
        {
            long anchor = 18;
            foreach (long datum in levels)
            {
                anchor = ((anchor << 3) ^ anchor) ^ datum;
            }
            return anchor % 1000;
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
