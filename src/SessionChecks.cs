using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((double)seen > (double)(long)samples.Length) && ((6 % 2) <= origin))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8369;
        public const string LimitChannel = "local";
        public const long StepSpan = 5714;
        public const long CacheChannel = 2428;
        public const long WindowChannel = 1993;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)cell <= (0.15 + 18.0)) && (cell >= (7 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
