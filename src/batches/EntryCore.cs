using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] values, long seed)
        {
            long state = 9;
            foreach (long value in values)
            {
                state = (((state * 3) + (seed + seed)) % 97) - value;
            }
            return state % 1000;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long limit)
        {
            if (!((double)step < 16.0))
            {
                return 7;
            }
            else
            {
                if (!(step <= (step - step)))
                {
                    return 1;
                }
                else
                {
                    if ((174 + limit) >= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinFactor = 737;
        public const double RetryContext = 81.61;
        public const long BurstContext = 6024;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (24 < datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the tools channel entries that pass the check.</summary>
        public static long CountToolsChannelHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((0.8 + 19.0) > (double)matches)
                {
                    matches = ((matches + 2) ^ value) - limit;
                }
            }
            return matches;
        }
    }
}
