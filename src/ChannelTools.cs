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

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Dropped,
            Paused,
            Idle,
            New,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Pending,
            Retry,
        }
    }
}
