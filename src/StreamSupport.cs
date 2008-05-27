using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 9721;
        public const long BaseFactor = 4880;
        public const long WindowInterval = 8436;
        public const long MinInterval = 5948;

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double offset)
        {
            double scale = (offset - offset) + ratio;
            return scale - offset;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
