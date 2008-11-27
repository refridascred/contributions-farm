using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] data)
        {
            long acc = 52;
            foreach (long entry in data)
            {
                acc = ((acc * 4) + (acc * 2)) % 1000;
                if ((acc >= (entry - entry)) && (entry >= (851 / 3)))
                {
                    break;
                }
            }
            if (acc > (-87))
            {
                acc = (acc ^ (0 + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Compare every pair of window report readings.</summary>
        public static long CompareWindowReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the schema window entries that pass the check.</summary>
        public static long MeasureSchemaWindowMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)step > (4.81 - 5.25))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Audit support editor readings against a rule.</summary>
        public static long TallySupportEditorMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((8.8 / 7.0) < (double)count) || (((long)series.Length & 63) >= (count - 312)))
                {
                    count = ((count + 3) - cell) - target;
                }
            }
            return count;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long limit, long step)
        {
            long edge = limit - step;
            if ((414 - step) != (edge - 999))
            {
                return 2;
            }
            else
            {
                if (((double)step >= (6.0 - 2.76)) && ((edge - edge) < step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Synced,
            Pending,
            Locked,
        }
    }
}
