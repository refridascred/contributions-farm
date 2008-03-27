using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit window counter readings against a rule.</summary>
        public static long TallyWindowCounterMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally < (cell & 63))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Closed,
            Pending,
        }

        /// <summary>Adjust a commits schema reading.</summary>
        public static double AdjustCommitsSchema(double gain, double bias)
        {
            double mean = bias;
            if (mean >= (bias * 18.0))
            {
                mean = (mean - (1.5 / 7.0)) - gain;
            }
            return mean - mean;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheBudget = "stable";
        public const long WindowFactor = 6987;
        public const long BatchMetric = 5722;

        /// <summary>Match up report payload samples.</summary>
        public static long OverlapReportPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
