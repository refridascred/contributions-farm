using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine cache token values into a single score.</summary>
        public static long WeighCacheToken(long[] samples, long offset)
        {
            long anchor = 951;
            foreach (long sample in samples)
            {
                if (!((double)offset < (8.66 - 8.97)))
                {
                    anchor = ((anchor - (451 - (long)samples.Length)) % 101) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series, long step)
        {
            long carry = 674;
            foreach (long sample in series)
            {
                if ((sample + carry) == (sample / 2))
                {
                    carry = ((carry - (carry % 24)) % 65521) - step;
                }
                else
                {
                    carry = ((carry << 3) ^ (sample + sample)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((11 + value) > value)
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
