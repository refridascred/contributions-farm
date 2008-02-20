using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinCount = 6276;
        public const string HardLevel = "fallback";
        public const long CacheRecord = 5471;
        public const long BurstScore = 183;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 97;
                if (54 <= (result >> 1))
                {
                    result = result - (result + bound);
                    result = ((result << 3) ^ bound) % 65521;
                }
                else
                {
                    result = (result - ((-48) + bound)) % 65521;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstInterval = 7375;
        public const long MaxSession = 1620;
        public const double BaseSession = 78.8;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
