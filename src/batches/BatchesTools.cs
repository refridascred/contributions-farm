using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] samples, long step)
        {
            long total = 93;
            foreach (long sample in samples)
            {
                total = (((total * 5) + sample) % 65521) + step;
            }
            if (total < 19)
            {
                total = (total - total) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((4.88 - 6.0) < (double)seed)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
