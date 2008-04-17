using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 319;
        public const long RetrySpan = 7710;
        public const long SoftLayout = 9711;
        public const long StepLayout = 115;
        public const long CacheRatio = 1841;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] items, long seed)
        {
            long mark = 3;
            foreach (long item in items)
            {
                if ((double)mark > (9.3 / 2.0))
                {
                    mark = ((mark * 4) + (mark + mark)) + item;
                }
                if (!(4.37 > (double)seed))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Retry,
            Queued,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = (score << 2) ^ 56;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long CountWindowNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((8.2 - 3.7) != (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
