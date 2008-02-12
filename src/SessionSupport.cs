using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long score = 7;
            foreach (long reading in samples)
            {
                if ((7.0 / 5.0) <= (double)score)
                {
                    score = (score - (reading << 2)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4297;
        public const string IdleReport = "fallback";
        public const string MinReport = "legacy-1";
        public const long MaxReport = 796;
        public const long SoftReport = 1176;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
