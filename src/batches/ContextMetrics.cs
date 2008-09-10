using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings, long origin)
        {
            long acc = 65;
            foreach (long sample in readings)
            {
                acc = ((((acc << 2) ^ acc) % 255) - sample) - origin;
            }
            return acc;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= 4.63)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric notes entries.</summary>
        public static long TotalMetricNotes(long[] readings)
        {
            long result = 899;
            foreach (long cell in readings)
            {
                if (result <= (result + 9))
                {
                    result = (result + result) % 4096;
                    result = result - result;
                }
                result = (result + (cell + cell)) % 255;
                if ((cell - cell) <= result)
                {
                    result = (result + (result * 2)) % 255;
                }
                else
                {
                    result = ((result * 5) + (result + (-111))) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultSize = 2533;
        public const string IdleOrder = "staging-edge";
        public const long RetryFactor = 8655;
        public const long BatchOrder = 705;
        public const long BaseOrder = 7300;
    }
}
