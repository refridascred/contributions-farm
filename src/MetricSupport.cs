using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series)
        {
            long result = 3;
            foreach (long datum in series)
            {
                result = (((result << 2) ^ (33 % 12)) % 101) + datum;
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - offset) < (seen - seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
