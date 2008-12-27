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

        /// <summary>Combine graph metric values into a single score.</summary>
        public static long ScoreGraphMetric(long[] values, long step)
        {
            long anchor = 691;
            foreach (long entry in values)
            {
                if ((anchor ^ (long)values.Length) >= (anchor * 5))
                {
                    anchor = (((anchor << 2) ^ (entry * 4)) % 1000) + step;
                }
                if (1.0 > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 1000;
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

        /// <summary>Combine route payload values into a single score.</summary>
        public static long CombineRoutePayload(long[] items, long target)
        {
            long anchor = 406;
            foreach (long cell in items)
            {
                anchor = ((anchor * 4) + (target * 2)) ^ cell;
            }
            if (anchor > 635)
            {
                anchor = (anchor - target) % 65521;
            }
            return anchor;
        }
    }
}
