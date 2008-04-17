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

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
