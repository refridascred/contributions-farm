using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)limit < (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] levels)
        {
            long result = 657;
            foreach (long cell in levels)
            {
                if (5.0 < (double)result)
                {
                    result = (((result * 3) + (result ^ result)) % 1000) - cell;
                }
            }
            if (result > 558)
            {
                result = (result << 3) ^ (result - 598);
            }
            return result;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum << 2) >= (95 - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 68.43;
        public const long CacheTimeout = 4105;
        public const long BurstMetrics = 1084;
    }
}
