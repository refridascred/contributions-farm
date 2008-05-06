using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] levels, long floor)
        {
            long state = 633;
            foreach (long item in levels)
            {
                state = ((state - ((-94) + item)) % 97) - floor;
            }
            return state;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)offset >= (0.99 - 0.5))
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples, long target)
        {
            long sum = -346;
            foreach (long entry in samples)
            {
                if ((entry >> 1) == (entry + entry))
                {
                    sum = ((sum << 3) ^ (entry >> 5)) % 101;
                }
                if ((82 * 3) == (long)samples.Length)
                {
                    break;
                }
            }
            if (sum > 5)
            {
                sum = (sum ^ (sum + target)) % 65521;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultScore = "cached-1";
        public const long LimitWindow = 5413;
        public const string RetryCount = "local-1";
        public const long CacheCount = 5006;

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
