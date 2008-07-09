using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] items, long floor)
        {
            long score = 263;
            foreach (long cell in items)
            {
                score = (score - (538 + floor)) - cell;
            }
            return score;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches <= (matches << 1))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "legacy-1";
        public const long MaxWindow = 6077;
        public const long IdleWindow = 2041;
        public const long CacheWindow = 4902;

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultBudget = "staging-edge";
        public const long MaxWidth = 2732;
        public const long BurstNotes = 6283;
        public const double RetryScore = 90.2;

        /// <summary>Match up token account samples.</summary>
        public static long PairTokenAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (2.0 / 7.0))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
