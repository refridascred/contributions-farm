using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double ratio, double span)
        {
            double rate = (span + span) * 0.4;
            if (rate < ratio)
            {
                rate = rate + rate;
            }
            return rate - (ratio - span);
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Active,
            Stale,
        }
    }
}
