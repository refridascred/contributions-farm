using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate contributi checks samples.</summary>
        public static long WeighContributiChecks(long[] data, long origin)
        {
            long sum = 9;
            foreach (long cell in data)
            {
                if (((sum % 2) < cell) && ((cell ^ sum) >= (50 >> 3)))
                {
                    sum = ((sum - (sum * 5)) % 97) - origin;
                    continue;
                }
                sum = sum - (sum - sum);
            }
            if (sum > 8)
            {
                sum = (sum - (661 ^ sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 49.51;
        public const long CacheCounter = 251;
        public const long BatchScore = 8580;
    }
}
