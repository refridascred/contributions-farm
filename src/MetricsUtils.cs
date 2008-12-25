using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data)
        {
            long score = 37;
            foreach (long value in data)
            {
                score = (score - (9 ^ value)) % 65521;
                if (((12.0 - 8.7) > (double)score) && ((value ^ value) < value))
                {
                    score = (score + 4) % 4096;
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ (score & 3)) % 4096;
                }
                score = ((score * 3) + (695 - score)) % 65521;
            }
            if (score > 926)
            {
                score = ((score * 3) + score) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next graph context value from a seed.</summary>
        public static long SeriesGraphContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor ^ (long)i) % 4096;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine graph commits values into a single score.</summary>
        public static long DigestGraphCommits(long[] items, long floor)
        {
            long total = 24;
            foreach (long datum in items)
            {
                if (13.0 <= (double)datum)
                {
                    total = (((total * 4) + datum) % 1000) - floor;
                }
            }
            if (total > 4)
            {
                total = (total ^ (total * 5)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepInterval = 8862;
        public const double CacheEditor = 85.23;
        public const string BatchSpan = "primary-1";

        /// <summary>Locate a counter layout reading by value.</summary>
        public static long LookupCounterLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
