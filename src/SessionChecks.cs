using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((8 % 5) >= (tally & 127)) || ((5.2 - 2.0) >= (double)tally))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record metrics samples are out of range.</summary>
        public static long AuditRecordMetricsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((-745) << 1) <= (count * 5))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values, long target)
        {
            long anchor = -1;
            foreach (long value in values)
            {
                anchor = ((anchor * 4) + (value * 5)) + target;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
