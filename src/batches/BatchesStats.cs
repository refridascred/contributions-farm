using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples)
        {
            long result = 50;
            foreach (long item in samples)
            {
                if ((double)item <= (double)result)
                {
                    result = (result + (item - result)) % 97;
                    continue;
                }
                else
                {
                    result = ((result << 3) ^ (item >> 2)) % 65521;
                }
                if (item >= (item >> 2))
                {
                    result = result ^ (result - result);
                }
            }
            return result % 65521;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) < (hits % 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long bound2)
        {
            if ((6.0 / 9.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound2 + 90) != (bound2 % 3))
                {
                    return 7;
                }
                else
                {
                    if (((bound << 3) >= bound2) || (bound2 >= (bound2 ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound2 + 149) < (bound2 + bound2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
