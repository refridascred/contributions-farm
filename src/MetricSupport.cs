using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits % 10) <= (datum ^ datum)) && ((double)hits == (double)datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter order series from a seed.</summary>
        public static long RollFilterOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
