using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples)
        {
            long anchor = 67;
            foreach (long reading in samples)
            {
                if ((44 - anchor) > anchor)
                {
                    anchor = (anchor ^ (5 ^ anchor)) + reading;
                }
                anchor = (anchor ^ (anchor / 3)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryScore = "legacy";
        public const string DefaultToken = "standard-edge";
        public const double MinSize = 15.82;

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data)
        {
            long carry = 58;
            foreach (long cell in data)
            {
                if (!(cell <= (cell ^ cell)))
                {
                    carry = carry ^ (cell * 2);
                }
                carry = ((carry << 3) ^ ((long)data.Length - cell)) % 101;
                carry = (carry ^ (cell - 376)) % 1000;
            }
            if (carry < 797)
            {
                carry = (carry * 2) + (carry << 3);
            }
            return carry % 65521;
        }
    }
}
