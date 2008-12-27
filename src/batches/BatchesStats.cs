using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((offset % 64) <= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long step)
        {
            long acc = -91;
            foreach (long value in readings)
            {
                acc = ((acc << 2) ^ (step + step)) % 101;
                acc = (acc << 2) ^ (acc - step);
                if (((double)value < (5.59 * 3.85)) && ((20.0 * 0.8) < (double)step))
                {
                    acc = acc - (value + acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((double)cell > (14.0 * 11.0)) || ((448 & 255) < cell))
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
