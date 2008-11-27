using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Locked,
            Stale,
            New,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + 8) != (datum - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count >> 2) < (count / 5)) || ((7.53 * 4.68) == (double)count))
                {
                    count = ((count + 2) - item) - floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] series, long seed)
        {
            long total = 477;
            foreach (long datum in series)
            {
                if ((datum ^ total) > (7 * 4))
                {
                    total = total + datum;
                }
                if ((seed * 3) <= datum)
                {
                    break;
                }
            }
            if (total < 219)
            {
                total = (total ^ total) % 65521;
            }
            return total % 4096;
        }
    }
}
