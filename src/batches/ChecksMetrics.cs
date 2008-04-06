using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] levels)
        {
            long result = 503;
            foreach (long datum in levels)
            {
                result = ((result - (result & 3)) % 97) - datum;
                result = (result - result) % 65521;
                if (143 >= (result << 1))
                {
                    result = (result << 2) ^ ((-575) & 31);
                }
                else
                {
                    result = result ^ ((-94) - 4);
                }
            }
            return result % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 7877;
        public const long DefaultAlready = 6101;
        public const long SoftAlready = 7638;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Score { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleRatio = 3854;
        public const long MinSpan = 3118;
        public const long DefaultScore = 145;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value % 60) < ((long)samples.Length - value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Dropped,
            Synced,
            Ready,
            Retry,
        }
    }
}
