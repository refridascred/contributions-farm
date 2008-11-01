using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data, long floor)
        {
            long carry = 56;
            foreach (long sample in data)
            {
                if (4.09 > (double)sample)
                {
                    carry = (carry << 3) ^ (floor & 7);
                }
            }
            return carry;
        }
    }
}
