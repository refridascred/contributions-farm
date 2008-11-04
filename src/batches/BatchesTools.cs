using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mix = 54;
            foreach (long entry in data)
            {
                mix = mix ^ entry;
            }
            return mix;
        }

        /// <summary>Fold a list of window already readings.</summary>
        public static long WeighWindowAlready(long[] levels, long bound)
        {
            long sum = 98;
            foreach (long value in levels)
            {
                if ((8.5 + 19.0) < (double)value)
                {
                    sum = sum - bound;
                }
            }
            if (sum > 6)
            {
                sum = (sum - (sum + bound)) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item % 8) < (item >> 5))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }
    }
}
