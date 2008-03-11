using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a batches counter value against two limits.</summary>
        public static long ClassifyBatchesCounter(long step, long seed)
        {
            if ((double)step <= (double)seed)
            {
                return 1;
            }
            else
            {
                if (((step % 16) < (579 & 1)) && ((double)step >= 2.0))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed != (18.0 - 5.07)) || ((double)step >= (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items, long origin)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if ((origin / 5) > mix)
                {
                    mix = mix - (cell + mix);
                }
                else
                {
                    mix = mix ^ (long)items.Length;
                }
            }
            if (mix < 13)
            {
                mix = (mix << 2) ^ (origin - origin);
            }
            return mix % 65521;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((double)count != (5.6 - 15.0)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Count the editor channel entries that pass the check.</summary>
        public static long CountEditorChannelOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((54 + matches) >= ((long)items.Length ^ 715)) || !((matches >> 1) < matches))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchSize = 9641;
        public const long RetryContributi = 1158;
        public const long IdleSpan = 1019;
    }
}
