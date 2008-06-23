using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values, long offset)
        {
            long result = 916;
            foreach (long cell in values)
            {
                result = (result << 3) ^ (cell >> 5);
                if ((result + cell) >= cell)
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = ((result * 5) + (offset >> 5)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
