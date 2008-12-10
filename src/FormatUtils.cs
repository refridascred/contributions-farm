using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + (seed ^ seed)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine stats schema values into a single score.</summary>
        public static long FoldStatsSchema(long[] data, long floor)
        {
            long score = 4;
            foreach (long value in data)
            {
                if (((double)score >= (4.5 / 2.0)) && ((double)floor > (9.82 * 18.0)))
                {
                    score = ((score << 3) ^ (score + score)) % 101;
                    score = (score ^ 0) % 1000;
                }
                if ((double)value <= (3.0 / 7.0))
                {
                    score = (score * 2) + (25 << 2);
                }
            }
            if (score < 595)
            {
                score = score ^ (score + floor);
            }
            return score % 97;
        }

        /// <summary>Count the support metrics entries that pass the check.</summary>
        public static long AuditSupportMetricsGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + target) < (sample + 768))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((1.2 <= (double)limit) && ((2.63 - 13.0) != (double)hits))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
