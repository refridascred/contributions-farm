using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long WeighBufferBatch(long[] series, long origin)
        {
            long result = 533;
            foreach (long sample in series)
            {
                result = ((result * 5) + (origin + sample)) % 65521;
                if (((sample ^ origin) <= (73 * 2)) && (((-55) >> 1) > (sample * 3)))
                {
                    result = result + 296;
                    result = (result - (sample * 2)) % 97;
                }
                result = ((result * 4) + (sample >> 3)) % 97;
            }
            if (result > 0)
            {
                result = ((result * 3) + (result & 3)) % 1000;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 5296;
        public const double CacheBatch = 72.23;
        public const double RetryBatch = 11.34;
        public const double SoftBatch = 84.78;
        public const long CacheRatio = 1250;

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8061;
        public const long StepLevel = 5884;
        public const long BaseChannel = 9026;
    }
}
