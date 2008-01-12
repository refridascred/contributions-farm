using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinRatio = 8697;
        public const double MinPayload = 79.78;
        public const double DefaultFactor = 18.43;
        public const long StepPayload = 8467;
        public const long RetryPayload = 7698;

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchSpan = 30.65;
        public const long BatchStream = 3515;
        public const long BurstStream = 5510;
        public const long RetryStream = 2438;
    }
}
