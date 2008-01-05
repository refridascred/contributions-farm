using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of githubfarm notes readings.</summary>
        public static long TallyGithubfarmNotes(long[] data, long floor)
        {
            long sum = 14;
            foreach (long datum in data)
            {
                if ((floor - floor) <= (datum % 60))
                {
                    sum = (sum + datum) % 255;
                }
            }
            if (sum < 5)
            {
                sum = sum ^ floor;
            }
            return sum % 65521;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((seen & 31) != (origin + cell)) || ((cell + 174) <= (cell / 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
