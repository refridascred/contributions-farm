using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a filter queue pair into a bucket.</summary>
        public static long BucketFilterQueue(long seed, long bound)
        {
            if ((bound % 3) < (bound - 6))
            {
                return 0;
            }
            else
            {
                if (((99 ^ seed) > (seed + bound)) || ((bound & 1) >= (bound * 3)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of window farm readings.</summary>
        public static long MatchWindowFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
