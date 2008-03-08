using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MinChannel = 25.58;
        public const double LimitCount = 48.79;
        public const long IdleChannel = 3183;

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowCount = 37.14;
        public const double RetryStream = 92.46;
        public const long HardStream = 4330;
        public const long SoftSize = 3889;
        public const long MaxWidth = 7147;

        /// <summary>Digest a series of schema session entries.</summary>
        public static long TallySchemaSession(long[] series, long floor)
        {
            long mark = 8;
            foreach (long datum in series)
            {
                mark = ((mark << 2) ^ (mark - floor)) + datum;
            }
            return mark % 4096;
        }
    }
}
