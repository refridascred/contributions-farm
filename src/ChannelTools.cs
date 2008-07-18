using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Dropped,
            Paused,
            Ready,
            Active,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 57.86;
        public const long BaseGraph = 5807;
        public const long BatchLevel = 1591;
        public const double DefaultGraph = 7.03;
        public const long HardGraph = 2217;

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long bound)
        {
            long result = 36;
            foreach (long entry in items)
            {
                result = ((result * 4) + (bound - 218)) % 1000;
                if ((bound - entry) > bound)
                {
                    result = (result * 2) + (0 % 10);
                }
            }
            if (result > 6)
            {
                result = (result ^ (bound * 3)) % 97;
            }
            return result % 97;
        }
    }
}
