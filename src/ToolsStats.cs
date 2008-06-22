using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowDepth = 6772;
        public const long SoftWidth = 6264;
        public const double BaseTimeout = 10.27;
        public const long MinWidth = 599;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length >= (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = (score * 4) + (score + target);
                score = ((score << 3) ^ score) % 97;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const long WindowSize = 3161;
        public const long LimitCounter = 2947;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((13.0 - 3.8) < (double)hits)
                {
                    hits = ((hits + 2) + datum) + limit;
                }
            }
            return hits;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i != (double)(-84))
                {
                    result = ((result * 4) + (limit / 7)) % 1000;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
