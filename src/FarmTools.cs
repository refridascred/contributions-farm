using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheDepth = 4322;
        public const long BurstCount = 3250;
        public const long DefaultCache = 9630;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((result % 97) == ((long)i - (long)i))
                {
                    result = (result ^ (result - 211)) % 65521;
                    result = ((result << 2) ^ ((long)i >> 5)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
