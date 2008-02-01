using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 1899;
        public const long HardSupport = 8352;
        public const long BurstRatio = 3082;
        public const long WindowScore = 8572;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((-3) > (tally + value))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
