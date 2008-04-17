using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of route stats entries.</summary>
        public static long CombineRouteStats(long[] samples)
        {
            long carry = 0;
            foreach (long sample in samples)
            {
                if ((2 >> 3) <= (sample - sample))
                {
                    carry = (carry - (carry - 4)) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally / 6) >= bound) && !((entry + tally) > (tally << 2)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
