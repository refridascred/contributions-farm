using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((67 * 2) <= count))
                {
                    count = ((count + 2) + item) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstScore = 2417;
        public const string BurstSize = "strict-edge";
        public const long MaxLevel = 8485;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Done,
            Synced,
        }
    }
}
