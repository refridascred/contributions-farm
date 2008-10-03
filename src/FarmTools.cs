using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches << 2) <= matches) || (matches < (bound + datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 8299;
        public const long StepNotes = 2346;
        public const long CacheNotes = 9500;
        public const long BaseNotes = 6819;
    }
}
