using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total * 3) + (offset - 648)) + (long)i2;
                }
                total = total ^ (offset % 16);
                total = (total + (total + total)) % 101;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
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
