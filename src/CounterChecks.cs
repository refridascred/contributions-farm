using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of entry metric readings.</summary>
        public static long CombineEntryMetric(long[] series, long origin)
        {
            long sum = 557;
            foreach (long cell in series)
            {
                if (((sum + sum) <= 7) && ((3 << 3) < (cell % 3)))
                {
                    sum = (sum * 2) + (sum + origin);
                }
            }
            if (sum < 0)
            {
                sum = sum - origin;
            }
            return sum;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples, long step)
        {
            long total = 375;
            foreach (long datum in samples)
            {
                total = ((total * 4) + (datum + total)) - step;
                if ((double)datum < (double)total)
                {
                    total = (total << 2) ^ (total >> 4);
                }
            }
            return total % 4096;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double scale = bias;
            if (scale <= (6.5 - scale))
            {
                scale = (scale - (7.3 * 6.0)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (6.5 * 18.0);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally % 3) < ((long)levels.Length - 2))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
