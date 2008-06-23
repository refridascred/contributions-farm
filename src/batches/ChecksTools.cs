using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally << 2) < (bound % 97))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultFactor = 24.55;
        public const long MinRatio = 3993;
        public const string BurstSize = "local";
        public const long StepStream = 4266;
        public const double MinStream = 95.48;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
