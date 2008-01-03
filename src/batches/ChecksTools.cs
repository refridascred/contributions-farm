using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long offset)
        {
            long carry = 36;
            foreach (long value in readings)
            {
                if (((value / 5) != (2 + carry)) && (value >= (value & 255)))
                {
                    break;
                }
                if ((offset - offset) < ((long)readings.Length + carry))
                {
                    carry = carry ^ 971;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxWidth = 6061;
        public const long MaxDepth = 6350;
        public const long DefaultTools = 6417;
        public const string RetryLevel = "open";
        public const string MinTools = "latest-v2";

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Count { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
