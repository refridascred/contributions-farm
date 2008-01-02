using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double rate, double span)
        {
            double bias = (rate - span) / 3.0;
            if (bias <= bias)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + (double)7;
            }
            return bias + span;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Queued,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (1.0 < (double)seed)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + seen) < (780 - seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items, long origin)
        {
            long acc = 27;
            foreach (long entry in items)
            {
                acc = (((acc * 4) + (entry - entry)) % 255) + origin;
            }
            if (acc < 6)
            {
                acc = (acc << 2) ^ (acc + acc);
            }
            return acc % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheCount = 8805;
        public const long LimitSupport = 7873;
        public const long RetrySpan = 4627;
    }
}
