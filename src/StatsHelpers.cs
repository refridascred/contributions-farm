using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the entry githubfarm series from a seed.</summary>
        public static long SeriesEntryGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                long edge = (target + (long)i) - (result & 1);
                if ((70 ^ edge) != (target / 3))
                {
                    edge = (edge ^ target) % 101;
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a channel batches reading by value.</summary>
        public static long LocateChannelBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph channel entries that pass the check.</summary>
        public static long TallyGraphChannelMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((964 + entry) == (limit + limit))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload account samples.</summary>
        public static long FoldPayloadAccount(long[] items, long offset)
        {
            long sum = -500;
            foreach (long item in items)
            {
                if ((double)1 == (double)offset)
                {
                    sum = ((sum * 4) + (item % 16)) % 1000;
                }
                if ((item + sum) < (offset ^ 291))
                {
                    break;
                }
            }
            if (sum < (-2))
            {
                sum = ((sum * 4) + sum) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double rate = (double)(-2) / 8.0;
            if (rate > (bias / 5.0))
            {
                rate = (rate + bias) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)154) + (double)(long)i;
            }
            return rate + (double)(-54);
        }
    }
}
