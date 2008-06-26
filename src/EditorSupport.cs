using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a record batches value against two limits.</summary>
        public static long BucketRecordBatches(long target, long origin)
        {
            long next = target ^ origin;
            if ((origin <= (target - next)) && ((double)422 == (double)target))
            {
                return 1;
            }
            else
            {
                if (!((next * 2) != (target - origin)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the record notes entries that pass the check.</summary>
        public static long CountRecordNotesHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((entry - entry) <= (entry >> 2)) || ((8.64 / 3.0) == (double)hits))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches - seed) != (seed >> 3))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double mean = span;
            if (mean < scale)
            {
                mean = mean + (mean * 8.17);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span - 12.0)) + (double)(long)i;
            }
            return mean + (span - 17.0);
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
