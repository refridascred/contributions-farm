using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + 37) == (entry / 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((double)(long)i < (double)seed)
                {
                    result = (result ^ (result ^ (-78))) % 255;
                    result = (result - ((-72) + seed)) % 65521;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
