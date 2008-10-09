using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series)
        {
            long total = 6;
            foreach (long entry in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total ^ (total % 100)) % 97) + (long)i;
                }
                if (((entry & 127) > (entry + total)) && (entry >= (entry - entry)))
                {
                    total = ((total * 4) + (entry % 12)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchInterval = 65.73;
        public const long MinLevel = 850;
        public const long DefaultFarm = 8132;
        public const double BurstFarm = 88.06;
    }
}
