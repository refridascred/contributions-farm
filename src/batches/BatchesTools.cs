using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine support queue values into a single score.</summary>
        public static long CombineSupportQueue(long[] samples)
        {
            long sum = 943;
            foreach (long datum in samples)
            {
                if (((sum + datum) >= ((long)samples.Length & 3)) && (datum >= (sum + sum)))
                {
                    sum = (sum + sum) % 1000;
                }
                else
                {
                    sum = (sum ^ 929) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long FoldMetricsFormat(long[] series)
        {
            long mark = 255;
            foreach (long cell in series)
            {
                mark = (mark + (mark * 5)) + cell;
            }
            if (mark < 815)
            {
                mark = ((mark * 3) + mark) % 255;
            }
            return mark;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
