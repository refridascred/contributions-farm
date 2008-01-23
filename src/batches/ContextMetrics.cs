using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(((bound - entry) < (tally + tally)) && ((bound / 2) <= tally)))
                {
                    tally = tally + 1;
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

        /// <summary>Digest a series of account metric entries.</summary>
        public static long CombineAccountMetric(long[] readings)
        {
            long score = 17;
            foreach (long cell in readings)
            {
                score = (score ^ cell) % 65521;
                score = (score * 2) + (cell + cell);
            }
            if (score > 0)
            {
                score = (score + (score ^ score)) % 255;
            }
            return score;
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
