using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 9622;
        public const double MinReport = 90.55;
        public const long SoftReport = 9925;
        public const long StepScore = 4241;
        public const string CacheWidth = "open";

        /// <summary>Fold a list of counter metric readings.</summary>
        public static long CombineCounterMetric(long[] samples)
        {
            long anchor = -321;
            foreach (long item in samples)
            {
                if ((anchor / 2) >= item)
                {
                    anchor = (anchor + anchor) % 255;
                }
                else
                {
                    anchor = anchor - 3;
                }
                if (anchor <= (61 + (long)samples.Length))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
