using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!(7.2 <= (double)step))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Check that every context batches entry stays within the limit.</summary>
        public static bool GuardContextBatchesRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many context queue samples are out of range.</summary>
        public static long AuditContextQueueMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item >= (7.0 * 6.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double floor)
        {
            double weight = scale * 6.5;
            if (weight <= 3.11)
            {
                weight = (weight + scale) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (scale * 3.0)) - (double)(long)i;
            }
            return weight + (double)45;
        }
    }
}
