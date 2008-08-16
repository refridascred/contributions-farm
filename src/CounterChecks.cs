using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "cached-1";
        public const long DefaultFactor = 5086;
        public const long RetryBatch = 196;
        public const long IdleFactor = 9904;
        public const string CacheBatch = "local";

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry << 3) ^ (carry - limit)) % 101;
                if (carry <= (carry / 4))
                {
                    carry = ((carry << 2) ^ (carry & 15)) % 65521;
                    carry = (carry * 5) + limit;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many tools editor samples are out of range.</summary>
        public static long TallyToolsEditorGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(3.0 > (double)reading))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster githubfarm samples.</summary>
        public static long TallyClusterGithubfarm(long[] samples, long seed)
        {
            long state = -773;
            foreach (long entry in samples)
            {
                state = (((state * 5) + entry) % 4096) + seed;
                if ((entry << 2) >= state)
                {
                    state = (state ^ entry) % 255;
                }
                else
                {
                    state = (state + (state * 4)) % 4096;
                }
                if (!(1.0 > (double)entry))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit batch entry readings against a rule.</summary>
        public static long AuditBatchEntryMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits > (sample - sample)) && (9 >= (sample + 751))) && ((limit ^ 56) <= (hits << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (23 <= (offset - 2))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
