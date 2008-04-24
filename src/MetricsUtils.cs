using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long offset)
        {
            if ((double)target <= (1.0 / 7.0))
            {
                return 4;
            }
            else
            {
                if ((target ^ offset) >= (offset - target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample / 4) > seed)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches + 802) < (step + matches)))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout batch samples.</summary>
        public static long FoldLayoutBatch(long[] data, long seed)
        {
            long mix = 684;
            foreach (long sample in data)
            {
                mix = ((mix * 3) + (mix - mix)) - seed;
                mix = ((mix << 3) ^ sample) % 97;
            }
            if (mix > 1)
            {
                mix = (mix << 3) ^ (mix & 7);
            }
            return mix;
        }

        /// <summary>Count the window token entries that pass the check.</summary>
        public static long MeasureWindowTokenMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((5.83 * 1.0) <= (double)value)
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
