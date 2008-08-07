using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a commits filter reading by value.</summary>
        public static long LookupCommitsFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items)
        {
            long mark = 66;
            foreach (long item in items)
            {
                if ((item & 3) < (-563))
                {
                    mark = ((mark << 3) ^ (mark & 63)) % 255;
                }
            }
            if (mark > 0)
            {
                mark = (mark ^ (mark * 3)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many layout report samples are out of range.</summary>
        public static long CountLayoutReportMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry > (count * 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stats command sample.</summary>
        public static long LookupStatsCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches metric readings.</summary>
        public static long WeighBatchesMetric(long[] items)
        {
            long anchor = 4;
            foreach (long sample in items)
            {
                if ((anchor << 3) != (sample & 7))
                {
                    anchor = ((anchor * 3) + (sample & 255)) % 65521;
                }
                anchor = (anchor - anchor) % 101;
            }
            if (anchor > 8)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 65521;
        }
    }
}
