using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] readings)
        {
            long mark = -2;
            foreach (long cell in readings)
            {
                if (!((5.5 + 3.26) <= (double)cell))
                {
                    mark = (mark * 3) + (mark + mark);
                }
            }
            return mark;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 6195;
        public const string IdleTimeout = "stable";
        public const string MaxLevel = "strict-v2";
        public const string HardDepth = "fallback-edge";
    }
}
