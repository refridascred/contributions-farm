using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardRatio = 7846;
        public const string BatchWidth = "fallback-1";
        public const string BatchRatio = "local";
        public const string LimitSupport = "fallback-v2";

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] samples)
        {
            long mix = 735;
            foreach (long entry in samples)
            {
                if ((entry >> 3) != (mix - mix))
                {
                    mix = (mix ^ (entry / 6)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                long tally = total * 5;
                if (5 < (tally + 700))
                {
                    tally = tally ^ (offset * 4);
                }
                else
                {
                    tally = tally ^ (total + total);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
