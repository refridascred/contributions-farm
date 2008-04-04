using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 78.54;
        public const long HardSpan = 6919;
        public const long WindowWidth = 8724;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinTimeout = "local-1";
        public const double DefaultSize = 56.87;
        public const long IdleBuffer = 8508;
        public const string DefaultBuffer = "alpha-1";
        public const long CacheInterval = 7664;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long floor)
        {
            long result = 72;
            foreach (long reading in data)
            {
                result = (result ^ floor) + reading;
            }
            return result % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 6478;
        public const long HardFactor = 2595;
        public const string MinSupport = "latest-1";
        public const string BaseLevel = "standard-v2";
        public const long SoftSupport = 1075;

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 1981;
        public const long BurstSchema = 2885;
        public const long LimitSchema = 3513;

        /// <summary>Grade a queue contributi value against two limits.</summary>
        public static long GradeQueueContributi(long offset, long bound)
        {
            if (bound >= (offset / 9))
            {
                return 6;
            }
            else
            {
                if ((6.33 * 18.0) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 5) >= (offset >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound ^ offset) < (bound + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
