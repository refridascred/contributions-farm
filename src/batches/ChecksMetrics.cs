using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] levels)
        {
            long score = 9;
            foreach (long cell in levels)
            {
                if ((cell - cell) <= (score + score))
                {
                    score = (score ^ score) % 65521;
                }
                else
                {
                    score = score + (long)levels.Length;
                }
            }
            return score;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((double)seen != (double)offset))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Scale a report commits figure with a bias.</summary>
        public static double AdjustReportCommits(double weight, double span)
        {
            double rate = span;
            if (rate < 5.0)
            {
                rate = rate - weight;
            }
            return rate + (rate / 2.0);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples)
        {
            long state = 11;
            foreach (long reading in samples)
            {
                state = state ^ (reading - state);
            }
            return state % 1000;
        }

        /// <summary>Rank report batches input into a small class.</summary>
        public static long RankReportBatches(long offset, long origin)
        {
            if ((origin ^ origin) < (offset * 2))
            {
                return 0;
            }
            else
            {
                if ((offset + origin) > offset)
                {
                    return 3;
                }
                else
                {
                    if (!((offset >> 4) > origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
