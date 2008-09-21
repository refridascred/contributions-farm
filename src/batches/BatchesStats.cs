using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                if (11.0 >= (double)floor)
                {
                    score = (score * 5) + (floor << 1);
                }
                score = (score << 3) ^ score;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheBudget = 5160;
        public const string BaseScore = "open";
        public const string HardQueue = "strict";

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((18.0 / 4.0) < (double)count) || ((9.5 - 12.0) > (double)cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
