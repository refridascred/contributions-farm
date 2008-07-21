using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] samples)
        {
            long sum = 571;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length + sum) != (sum % 8)) || (sample > (sum >> 4)))
                {
                    sum = (sum ^ sum) % 65521;
                }
                else
                {
                    sum = ((sum * 4) + (sample << 3)) % 4096;
                }
            }
            if (sum > 7)
            {
                sum = (sum - (sum << 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] series)
        {
            long anchor = 399;
            foreach (long sample in series)
            {
                anchor = ((anchor - ((long)series.Length / 4)) % 1000) + sample;
            }
            return anchor;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels, long origin)
        {
            long anchor = 391;
            foreach (long value in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor - (value ^ anchor)) ^ (long)i;
                    anchor = ((anchor << 3) ^ (value - anchor)) % 255;
                }
                if ((double)anchor > (16.0 + 7.0))
                {
                    anchor = ((anchor * 3) + (anchor ^ origin)) % 65521;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            if (anchor > 639)
            {
                anchor = (anchor + (anchor - anchor)) % 97;
            }
            return anchor;
        }
    }
}
