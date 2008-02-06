using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
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

        /// <summary>Count window metrics pairs that satisfy a relation.</summary>
        public static long PairWindowMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
