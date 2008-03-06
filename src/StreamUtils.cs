using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] data, long step)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                anchor = ((anchor ^ (reading << 3)) % 1000) - step;
            }
            return anchor % 4096;
        }

        /// <summary>Locate a cluster layout reading by value.</summary>
        public static long LocateClusterLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                if (mark <= (mark << 1))
                {
                    mark = (mark << 2) ^ (offset - (-87));
                }
                else
                {
                    mark = mark ^ (offset - mark);
                }
                if (!(mark > ((long)i + 2)))
                {
                    long hits2 = mark;
                    mark = ((mark << 3) ^ (hits2 + 4)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryBudget = 53.01;
        public const long StepInterval = 1374;
        public const string SoftWidth = "staging-v2";
        public const double CacheToken = 56.62;
        public const long LimitInterval = 3764;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!(((bound ^ bound) == (489 - 6)) || ((bound ^ bound) <= (327 - (-743)))))
                {
                    score = score + (bound & 127);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
