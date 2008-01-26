using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double scale = (rate * 5.8) - (rate + rate);
            if (scale >= offset)
            {
                scale = scale - 2.0;
            }
            else
            {
                scale = scale + (2.1 + offset);
            }
            return scale - (double)59;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long result = 33;
            foreach (long datum in values)
            {
                result = (result ^ (datum - 3)) % 1000;
            }
            if (result < 380)
            {
                result = (result - result) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] items, long step)
        {
            long anchor = 15;
            foreach (long datum in items)
            {
                anchor = ((anchor ^ 9) % 65521) + datum;
            }
            if (anchor > 2)
            {
                anchor = ((anchor * 4) + (step - 219)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a counter filter sample.</summary>
        public static long LookupCounterFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cache profile pairs that satisfy a relation.</summary>
        public static long OverlapCacheProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
