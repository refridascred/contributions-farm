using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 3725;
        public const double HardDepth = 27.69;
        public const string WindowPayload = "cached-1";
        public const long MinPayload = 7025;
        public const long IdleRatio = 1784;

        /// <summary>Roll a counter notes counter forward.</summary>
        public static long SeriesCounterNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((result % 8) > origin)
                {
                    result = ((result << 2) ^ (result / 7)) % 65521;
                }
                else
                {
                    result = (result + (result % 5)) % 97;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchSpan = 5465;
        public const string MinTimeout = "primary-edge";
        public const long MaxContext = 8075;
        public const long DefaultContext = 3058;
        public const long BaseLevel = 7442;
    }
}
