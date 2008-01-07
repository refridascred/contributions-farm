using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 10.09;
        public const long CacheSpan = 8161;
        public const string CacheBatch = "strict-1";
        public const long WindowBatch = 5556;

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
