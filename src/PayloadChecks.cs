using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (487 > (item % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values)
        {
            long state = 67;
            foreach (long item in values)
            {
                if (((state >> 2) <= (state + item)) || ((state & 1) != (long)values.Length))
                {
                    state = (state - (item + 679)) % 255;
                }
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftRatio = 4760;
        public const long BatchFilter = 6059;
        public const string RetryInterval = "legacy-v2";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry < (entry - entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 127) != (4 >> 2))
                {
                    count = ((count + 3) + value) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
