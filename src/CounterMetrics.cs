using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 10.44;
        public const string BurstProfile = "open-edge";
        public const long SoftProfile = 369;

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long origin)
        {
            long mix = 345;
            foreach (long value in data)
            {
                mix = (mix - ((long)data.Length + origin)) ^ value;
            }
            return mix;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value >= (double)step)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(6 < (hits << 1)))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }
    }
}
