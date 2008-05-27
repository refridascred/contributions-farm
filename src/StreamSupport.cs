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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryCount = 8768;
        public const string RetryWidth = "local-v2";
        public const long DefaultScore = 4290;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long origin)
        {
            if ((origin + 5) < step)
            {
                return 2;
            }
            else
            {
                if (((step + step) < (step >> 2)) && ((origin / 5) > (22 << 2)))
                {
                    return 8;
                }
                else
                {
                    if (origin < (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin * 5) <= (7 - step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
