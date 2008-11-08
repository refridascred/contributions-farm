using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine metrics account values into a single score.</summary>
        public static long CombineMetricsAccount(long[] data)
        {
            long score = 927;
            foreach (long entry in data)
            {
                score = (score * 4) + (entry + 673);
            }
            return score;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((double)(-686) >= (1.0 / 5.0)) || ((double)entry != (double)tally)))
                {
                    tally = tally + 1;
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
