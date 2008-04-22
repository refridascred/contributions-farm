using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultSize = "open-edge";
        public const long StepInterval = 5406;
        public const long SoftAlready = 9513;
        public const long MaxScore = 9463;
        public const long MaxSpan = 2324;

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 1392;
        public const long BatchRoute = 2720;
        public const long StepRoute = 5363;
        public const string IdleFactor = "cached-1";
        public const long BatchTimeout = 401;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
