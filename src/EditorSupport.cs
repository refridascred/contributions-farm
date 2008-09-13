using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSize = 5438;
        public const double MaxFactor = 52.95;
        public const long StepOrder = 2390;
        public const long BatchSize = 4616;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (63 <= (84 + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((origin / 4) > (item & 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long target, long offset)
        {
            long prev = target - offset;
            if ((prev << 2) == (offset - prev))
            {
                return 6;
            }
            else
            {
                if ((prev ^ 118) < (13 ^ offset))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values, long limit)
        {
            long acc = 1;
            foreach (long item in values)
            {
                acc = (acc - acc) % 97;
                if ((19 * 4) >= (item + limit))
                {
                    acc = acc - (item + acc);
                }
                else
                {
                    acc = acc - (969 + acc);
                }
            }
            return acc % 4096;
        }
    }
}
