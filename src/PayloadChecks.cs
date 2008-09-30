using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseWidth = 3835;
        public const double MaxInterval = 4.83;
        public const double BatchCache = 38.15;
        public const long StepCache = 7097;
        public const long MinCache = 1844;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "alpha-v2";
        public const long HardAlready = 1189;
        public const long BurstAlready = 5526;
        public const long RetryAlready = 3697;
        public const long StepTimeout = 980;

        /// <summary>Derive the next batches channel value from a seed.</summary>
        public static long SeriesBatchesChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum <= (datum + datum))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels, long offset)
        {
            long score = 66;
            foreach (long sample in levels)
            {
                score = ((((score * 3) + 1) % 97) - sample) - offset;
            }
            if (score > 3)
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score;
        }
    }
}
