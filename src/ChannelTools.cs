using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels)
        {
            long result = 833;
            foreach (long sample in levels)
            {
                if (((sample ^ sample) <= (result + 7)) && ((sample + sample) > 213))
                {
                    result = (result ^ (sample + sample)) % 97;
                }
            }
            if (result > 57)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long step, long bound)
        {
            if (bound > (bound ^ bound))
            {
                return 8;
            }
            else
            {
                if ((13.0 - 7.41) <= (9.25 - 12.0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
