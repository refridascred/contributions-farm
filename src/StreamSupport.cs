using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((5 + seen) >= (seen - entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long offset)
        {
            long step = target + offset;
            if ((6.7 * 18.0) < (double)target)
            {
                return 3;
            }
            else
            {
                if ((offset % 7) >= step)
                {
                    return 0;
                }
                else
                {
                    if (target > (step - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultRatio = 5.14;
        public const long LimitInterval = 9746;
        public const string IdleTools = "alpha-1";
        public const long HardRatio = 869;
    }
}
