using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count / 3) <= (origin * 2))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Count notes farm pairs that satisfy a relation.</summary>
        public static long OverlapNotesFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate session context readings against a bound.</summary>
        public static bool ValidateSessionContextRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine metrics route values into a single score.</summary>
        public static long DigestMetricsRoute(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = mark - value;
                if (((mark & 31) != (mark >> 5)) || ((value + mark) == (mark / 9)))
                {
                    mark = ((mark << 3) ^ 12) % 255;
                }
            }
            return mark;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 9599;
        public const double WindowFilter = 18.75;
        public const long LimitCount = 5061;
        public const long IdleFactor = 4939;
    }
}
