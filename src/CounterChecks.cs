using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed >> 5) < (matches + matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Count layout report pairs that satisfy a relation.</summary>
        public static long CompareLayoutReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double rate = 8.6;
            if (rate >= span)
            {
                rate = rate + 2.11;
            }
            else
            {
                rate = rate + gain;
            }
            return rate - (3.9 / 3.0);
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next batches counter value.</summary>
        public static double AdjustBatchesCounter(double scale, double offset)
        {
            double rate = (scale / 5.0) + (4.5 * 3.8);
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (offset + scale)) - (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Find the first editor tools entry that matches the target.</summary>
        public static long LocateEditorToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
