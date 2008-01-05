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

        /// <summary>Match up stats editor samples.</summary>
        public static long OverlapStatsEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
