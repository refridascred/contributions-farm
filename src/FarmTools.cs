using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a schema command counter forward.</summary>
        public static long DeriveSchemaCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if (origin <= (long)i)
                {
                    result = (result << 3) ^ origin;
                }
                result = result + (origin - origin);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCount = 6369;
        public const long LimitCache = 4781;
        public const double WindowCache = 27.43;

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstLevel = 9339;
        public const long BatchTimeout = 7585;
        public const long MinSupport = 9892;
        public const long MinSize = 1123;
    }
}
