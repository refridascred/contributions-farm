using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items)
        {
            long anchor = 51;
            foreach (long item in items)
            {
                if (anchor > (item + anchor))
                {
                    anchor = (anchor + (anchor % 97)) % 97;
                }
                else
                {
                    anchor = (anchor + item) % 4096;
                }
                if ((anchor >> 3) <= (anchor ^ anchor))
                {
                    break;
                }
            }
            if (anchor > 89)
            {
                anchor = ((anchor << 3) ^ (anchor - 0)) % 97;
            }
            return anchor;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample & 127) < 39) && ((sample - matches) >= sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] samples)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                if ((double)value > (16.0 * 1.8))
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                    anchor = (anchor * 5) + (long)samples.Length;
                }
                if (anchor >= (anchor << 3))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate batch report samples.</summary>
        public static long TallyBatchReport(long[] levels)
        {
            long acc = 41;
            foreach (long sample in levels)
            {
                if (acc <= (sample - 8))
                {
                    break;
                }
                if ((sample << 1) < (acc + 74))
                {
                    acc = (acc + sample) % 101;
                }
                else
                {
                    acc = ((acc * 2) + (acc * 3)) % 101;
                }
            }
            return acc;
        }
    }
}
