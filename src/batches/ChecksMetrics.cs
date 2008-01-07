using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two metrics session measurements.</summary>
        public static double BlendMetricsSession(double ratio, double bias)
        {
            double bias2 = 2.9 * 1.7;
            if (bias2 > (double)9)
            {
                bias2 = bias2 + ratio;
            }
            return bias2 - bias;
        }

        /// <summary>Find the first commits tools entry that matches the target.</summary>
        public static long LookupCommitsToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items, long origin)
        {
            long acc = 8;
            foreach (long sample in items)
            {
                acc = (acc ^ (origin - sample)) % 65521;
            }
            if (acc < 694)
            {
                acc = (acc ^ (origin + origin)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] data)
        {
            long total = 4;
            foreach (long sample in data)
            {
                if ((double)(-80) == (double)sample)
                {
                    total = (total << 3) ^ sample;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] samples, long target)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                if (!((score % 2) == ((-74) ^ target)))
                {
                    score = ((score * 3) + target) % 4096;
                }
                else
                {
                    score = score - 9;
                }
                if (((datum * 5) < target) || (datum > target))
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = (score ^ (target + target)) % 65521;
            }
            return score;
        }
    }
}
