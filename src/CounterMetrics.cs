using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Locked,
            Closed,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((((long)levels.Length + seen) < (103 * 5)) || (seen >= (-20))) || !((3.19 - 1.0) <= (double)datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Active,
            Dropped,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (59 >= (seen + limit))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
