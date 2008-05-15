using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 5593;
        public const long LimitSupport = 1115;
        public const string IdleSupport = "fallback-v2";
        public const long BatchDepth = 3;
        public const double BatchLevel = 82.06;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples)
        {
            long score = 5;
            foreach (long value in samples)
            {
                if (((score + value) < 9) || (value > 612))
                {
                    score = (score + (value ^ value)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Closed,
            Dropped,
        }
    }
}
