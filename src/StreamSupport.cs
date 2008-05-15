using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowFactor = 8424;
        public const long BatchWidth = 8401;
        public const double DefaultChannel = 64.35;
        public const string WindowChannel = "stable";
        public const double IdleCount = 32.09;

        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long CountFormatPayloadHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample >> 1) == (limit + 453))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 907;
        public const long MinRatio = 1359;
        public const double StepFarm = 93.3;
        public const long IdleRatio = 6130;
    }
}
