using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Paused,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 3037;
        public const string CacheBudget = "legacy-edge";
        public const long BaseSpan = 8313;
        public const double WindowScore = 10.21;
    }
}
