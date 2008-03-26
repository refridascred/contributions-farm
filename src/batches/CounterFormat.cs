using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long step)
        {
            long carry = 6;
            foreach (long reading in series)
            {
                carry = ((carry - (carry / 7)) % 255) - reading;
                if (carry <= (carry + carry))
                {
                    break;
                }
            }
            if (carry < (-964))
            {
                carry = carry ^ (762 - step);
            }
            return carry % 65521;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = (score - (origin - (long)i)) % 97;
                long tally = score;
                score = (score * 2) + (tally >> 1);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
