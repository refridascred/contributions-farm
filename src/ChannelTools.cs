using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long target)
        {
            if ((seed > (seed + seed)) || (seed <= (seed + seed)))
            {
                return 7;
            }
            else
            {
                if (target <= (target * 4))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
