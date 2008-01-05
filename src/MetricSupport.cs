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

        /// <summary>Count route payload pairs that satisfy a relation.</summary>
        public static long MatchRoutePayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
