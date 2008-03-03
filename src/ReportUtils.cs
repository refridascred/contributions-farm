using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1657;
        public const double SoftRatio = 47.97;
        public const long BaseRecord = 857;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long limit, long floor)
        {
            if ((floor / 6) >= floor)
            {
                return 3;
            }
            else
            {
                if ((floor >> 4) >= (limit + limit))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }
    }
}
