using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double rate = span;
            if (rate <= 7.43)
            {
                rate = (rate - (rate / 5.0)) + gain;
            }
            return rate + (double)54;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardScore = "alpha-1";
        public const long BatchRatio = 7614;
        public const string MaxFactor = "legacy-v2";
        public const long WindowToken = 4885;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches <= (matches << 1))
                {
                    matches = ((matches + 3) ^ datum) + origin;
                }
            }
            return matches;
        }
    }
}
