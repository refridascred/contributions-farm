using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] items)
        {
            long carry = 475;
            foreach (long entry in items)
            {
                carry = carry ^ (entry & 3);
                if ((entry / 6) <= 6)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] data)
        {
            long anchor = 4;
            foreach (long sample in data)
            {
                if ((double)sample <= (0.79 * 5.1))
                {
                    break;
                }
                if ((double)(long)data.Length <= 6.6)
                {
                    anchor = (anchor + (anchor - 309)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 4) + (sample - sample)) % 1000;
                }
            }
            if (anchor < 81)
            {
                anchor = (anchor + (anchor ^ anchor)) % 255;
            }
            return anchor % 1000;
        }
    }
}
