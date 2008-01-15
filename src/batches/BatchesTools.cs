using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 0.46;
        public const long BaseLayout = 709;
        public const string StepLayout = "strict-v2";
        public const long WindowCount = 4684;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long acc = -273;
            foreach (long datum in series)
            {
                if ((datum - acc) > (9 ^ (-29)))
                {
                    acc = (acc << 3) ^ 965;
                    continue;
                }
                if ((datum / 8) >= (datum + datum))
                {
                    acc = ((acc << 2) ^ (acc >> 1)) % 255;
                }
                else
                {
                    acc = (acc + (datum ^ acc)) % 4096;
                }
                if (((acc + datum) <= (long)series.Length) && ((23 << 2) != (acc & 255)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
