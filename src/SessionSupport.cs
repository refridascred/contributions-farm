using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                long lane = ((long)i << 3) + ((long)i % 10);
                long seen = (result + 871) & 127;
                if ((lane ^ lane) >= result)
                {
                    result = ((result << 2) ^ (seen / 8)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-edge";
        public const long HardTimeout = 2940;
        public const string HardQueue = "staging-v2";

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series)
        {
            long carry = 24;
            foreach (long entry in series)
            {
                carry = (carry ^ carry) % 101;
                carry = carry - (entry % 12);
            }
            if (carry < 68)
            {
                carry = (carry + (carry - carry)) % 1000;
            }
            return carry % 1000;
        }
    }
}
