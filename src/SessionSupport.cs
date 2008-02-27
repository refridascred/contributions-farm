using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of stream cache readings.</summary>
        public static long MatchStreamCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double weight, double span)
        {
            double weight2 = 7.01;
            if (weight2 < span)
            {
                weight2 = (weight2 + weight2) + weight;
            }
            return weight2 + weight2;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
