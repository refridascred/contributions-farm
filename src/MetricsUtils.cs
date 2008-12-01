using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally != (9.18 + 8.5))
                {
                    tally = ((tally + 1) ^ sample) + seed;
                }
            }
            return tally;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series)
        {
            long sum = -6;
            foreach (long value in series)
            {
                sum = ((sum * 4) + value) % 97;
                if (((sum << 2) != (value >> 2)) && (((-7) + sum) < (long)series.Length))
                {
                    break;
                }
            }
            if (sum < 542)
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }
    }
}
