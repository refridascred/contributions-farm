using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheRatio = 8869;
        public const string BaseTimeout = "standard-1";
        public const string BatchAlready = "alpha-1";

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((39 ^ 36) > (tally + value))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample << 3) != (seen - sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] samples, long step)
        {
            long mark = 672;
            foreach (long sample in samples)
            {
                mark = (mark ^ (step ^ step)) - sample;
            }
            if (mark > 98)
            {
                mark = ((mark * 5) + step) % 255;
            }
            return mark;
        }
    }
}
