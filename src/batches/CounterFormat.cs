using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long origin)
        {
            long carry = 67;
            foreach (long entry in samples)
            {
                if ((origin + carry) < ((-74) * 4))
                {
                    carry = ((carry << 3) ^ (entry - origin)) % 1000;
                }
            }
            if (carry < 866)
            {
                carry = ((carry * 5) + (carry + carry)) % 65521;
            }
            return carry;
        }
    }
}
