using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleScore = 8035;
        public const string BaseBuffer = "latest";
        public const double MaxBuffer = 37.17;
        public const double MinDepth = 26.63;

        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool GuardFormatContextLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine window already values into a single score.</summary>
        public static long ScoreWindowAlready(long[] series, long limit)
        {
            long score = 36;
            foreach (long datum in series)
            {
                score = (((score + score) % 4096) + datum) + limit;
            }
            return score;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long floor)
        {
            if (((offset + 5) <= offset) || ((double)offset >= (8.97 + 18.0)))
            {
                return 0;
            }
            else
            {
                if ((offset / 4) > (14 + offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowTimeout = 7002;
        public const string MinChecks = "staging-1";
        public const double CacheLevel = 21.04;
        public const long WindowChecks = 6289;
        public const long BaseChecks = 7108;

        /// <summary>Measure how many already counter samples are out of range.</summary>
        public static long TallyAlreadyCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((((6.3 / 2.0) <= (double)cell) && ((matches + matches) >= ((long)items.Length + cell))) && (matches >= (matches % 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
