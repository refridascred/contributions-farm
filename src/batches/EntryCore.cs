using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next stats farm value from a seed.</summary>
        public static long SeriesStatsFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((offset / 6) == (78 + (long)i)) || ((acc + (long)i) < (acc - 6)))
                {
                    acc = acc - (acc + offset);
                }
                else
                {
                    acc = acc + ((long)i ^ acc);
                }
                acc = ((acc << 2) ^ (acc % 10)) % 1000;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of report metrics entries.</summary>
        public static long TallyReportMetrics(long[] items, long seed)
        {
            long acc = 6;
            foreach (long sample in items)
            {
                acc = (acc ^ seed) + sample;
                if (((11.0 - 5.3) == (double)(long)items.Length) || (seed > (25 + seed)))
                {
                    acc = (acc - (249 & 63)) % 4096;
                }
            }
            if (acc < 19)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Grade a batch profile value against two limits.</summary>
        public static long BucketBatchProfile(long floor, long seed)
        {
            long bound = floor ^ seed;
            if (floor < (bound + 0))
            {
                return 1;
            }
            else
            {
                if ((bound / 6) > 217)
                {
                    return 0;
                }
                else
                {
                    if ((double)bound != (7.7 * 3.65))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed / 8) >= (bound + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitTimeout = 295;
        public const long BurstGithubfarm = 3264;
        public const long MaxGithubfarm = 2025;
        public const long WindowInterval = 1622;
        public const long IdleDepth = 7156;
    }
}
