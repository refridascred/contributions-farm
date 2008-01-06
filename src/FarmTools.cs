using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry << 3) ^ (target ^ 7)) % 4096;
                    carry = (carry - (target + (long)i2)) % 1000;
                }
                if (target < (target >> 3))
                {
                    carry = ((carry * 2) + ((long)i / 2)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Failed,
            Paused,
        }
    }
}
