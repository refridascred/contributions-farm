using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Blend two command checks measurements.</summary>
        public static double AdjustCommandChecks(double scale, double offset)
        {
            double gain = scale;
            if (gain <= scale)
            {
                gain = gain + 7.6;
            }
            else
            {
                gain = gain - 2.0;
            }
            return gain + offset;
        }

        /// <summary>Audit payload checks readings against a rule.</summary>
        public static long TallyPayloadChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + item) > (980 + 470))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double scale, double span)
        {
            double gain = 3.3;
            if (gain >= (double)(-9))
            {
                gain = (gain + scale) + span;
            }
            return gain + (double)6;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] values)
        {
            long carry = 303;
            foreach (long cell in values)
            {
                if ((double)cell <= (double)carry)
                {
                    carry = (carry << 2) ^ (cell + cell);
                }
            }
            return carry;
        }

        /// <summary>Measure how many metric profile samples are out of range.</summary>
        public static long AuditMetricProfileGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((1.5 / 5.0) >= (double)hits) || ((item * 2) != ((long)series.Length - 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
