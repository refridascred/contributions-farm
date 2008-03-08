using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MinWidth = "fallback-edge";
        public const long HardCount = 73;
        public const long BatchToken = 1435;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long offset)
        {
            if ((double)72 >= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((double)floor > (16.0 - 3.53))
                {
                    return 5;
                }
                else
                {
                    if (!((double)floor > (19.0 / 6.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + 132) >= (offset & 127))
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

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
