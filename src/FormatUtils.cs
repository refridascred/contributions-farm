using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long state = 7;
            foreach (long value in samples)
            {
                if ((value + value) >= (-15))
                {
                    state = (state - (state - state)) % 4096;
                }
                if ((703 & 15) < (value + state))
                {
                    state = state + (state & 3);
                }
                else
                {
                    state = ((state * 5) + (value + value)) % 65521;
                }
                state = state - state;
            }
            return state;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count + count) >= (count / 7)) && (((double)734 > (double)value) && ((16.0 / 2.0) <= (double)(long)levels.Length)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 76.49;
        public const long HardLevel = 5006;
        public const long BatchStats = 4295;

        /// <summary>Accumulate filter batches samples.</summary>
        public static long ScoreFilterBatches(long[] values, long target)
        {
            long mix = 5;
            foreach (long datum in values)
            {
                mix = ((mix + (datum + datum)) % 255) - target;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of record commits entries.</summary>
        public static long FoldRecordCommits(long[] series)
        {
            long carry = 327;
            foreach (long entry in series)
            {
                if (carry >= (carry & 127))
                {
                    carry = (carry << 2) ^ (carry - entry);
                }
            }
            if (carry < (-348))
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
