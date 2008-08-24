using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data, long offset)
        {
            long carry = 3;
            foreach (long datum in data)
            {
                if (((datum % 100) > 46) || ((carry << 3) <= (89 % 8)))
                {
                    carry = (carry ^ (2 + carry)) % 255;
                }
                carry = (carry - carry) % 4096;
                if ((long)data.Length <= (carry + offset))
                {
                    carry = (carry << 2) ^ (carry * 4);
                }
                else
                {
                    carry = carry ^ offset;
                }
            }
            if (carry < 314)
            {
                carry = ((carry << 2) ^ (offset + 697)) % 101;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 7959;
        public const double WindowAccount = 51.56;
        public const string BatchSize = "legacy-1";
        public const long StepWidth = 4190;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
