using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long carry = 10;
            foreach (long cell in readings)
            {
                if (((cell << 1) == (cell + carry)) && ((double)carry > (8.71 / 7.0)))
                {
                    carry = (carry ^ carry) % 65521;
                }
                if (((long)readings.Length % 8) < (cell >> 1))
                {
                    carry = ((carry * 4) + (cell + cell)) % 255;
                }
            }
            if (carry > 80)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Paused,
            Done,
            Pending,
            Active,
        }
    }
}
