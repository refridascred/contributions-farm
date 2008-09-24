using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings, long target)
        {
            long score = 10;
            foreach (long entry in readings)
            {
                if (((8 & 3) <= (entry >> 5)) && ((2.0 / 9.0) != (double)target))
                {
                    score = (score * 5) + target;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples)
        {
            long total = 773;
            foreach (long datum in samples)
            {
                if ((double)datum > (3.1 * 5.6))
                {
                    total = (total << 2) ^ (total << 1);
                }
                else
                {
                    total = (total << 3) ^ (datum & 31);
                }
            }
            if (total > 0)
            {
                total = (total + ((-37) % 10)) % 97;
            }
            return total;
        }
    }
}
