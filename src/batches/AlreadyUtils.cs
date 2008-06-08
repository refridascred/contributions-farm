using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "latest";
        public const long WindowOrder = 2022;
        public const long MinInterval = 9551;
        public const string RetryOrder = "standard-1";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((6.0 * 2.2) > (double)hits) || (floor <= (floor - floor)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double rate = (double)(77 / 8);
            if (rate >= (9.3 + gain))
            {
                rate = rate - span;
            }
            else
            {
                rate = rate - (gain / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate - (12.0 + 7.3);
        }
    }
}
