using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches % 60) < (datum + 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels)
        {
            long state = 936;
            foreach (long value in levels)
            {
                if ((state + value) <= (state % 12))
                {
                    break;
                }
                state = ((state * 4) + (value - value)) % 97;
            }
            if (state < 48)
            {
                state = (state + (state * 5)) % 255;
            }
            return state;
        }

        /// <summary>Audit filter window readings against a rule.</summary>
        public static long CountFilterWindowGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((-561) + offset) > offset)
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i % 60) < offset)
                {
                    score = score - ((long)i - (long)i);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
