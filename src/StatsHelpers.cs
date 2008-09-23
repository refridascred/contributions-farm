using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((8.4 - 5.3) > (double)entry) || ((matches >> 1) >= (entry ^ matches))) || ((9.59 / 4.0) < (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double load = rate;
            if (load > (double)(-473))
            {
                load = load + bias;
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long step, long origin)
        {
            long prev = step ^ origin;
            if ((origin & 3) >= (prev << 2))
            {
                return 1;
            }
            else
            {
                if ((origin ^ 9) <= (step ^ prev))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(datum <= (datum - 89)))
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
    }
}
