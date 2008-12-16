using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next context buffer value.</summary>
        public static double ScaleContextBuffer(double rate, double bias)
        {
            double weight = (double)((-3) - 19);
            return ((weight - (11.0 + 3.45)) + rate) + bias;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - (step << 2)) % 65521;
                if (!((89 + 6) <= carry))
                {
                    long span = (carry + carry) >> 4;
                    carry = (carry - (step + span)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 6875;
        public const string BaseChannel = "staging";
        public const string HardCount = "stable-v2";
    }
}
