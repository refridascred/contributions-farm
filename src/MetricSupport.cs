using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long AuditEditorCacheHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value - tally) <= step)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                if ((datum + (-122)) > datum)
                {
                    sum = sum + (90 << 3);
                }
                else
                {
                    sum = (sum + (-86)) % 97;
                }
            }
            if (sum > 49)
            {
                sum = ((sum << 3) ^ (sum % 10)) % 4096;
            }
            return sum % 1000;
        }
    }
}
