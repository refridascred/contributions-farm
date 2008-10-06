using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] values)
        {
            long carry = 282;
            foreach (long item in values)
            {
                if (((double)item < (double)carry) || ((carry >> 3) == (item >> 1)))
                {
                    carry = (carry ^ (carry % 100)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (item ^ item);
                }
            }
            if (carry > (-701))
            {
                carry = (carry * 5) + (carry + carry);
            }
            return carry;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleBudget = 5892;
        public const long StepTimeout = 286;
        public const double RetryNotes = 12.32;

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "strict-edge";
        public const string HardInterval = "strict-1";
        public const string HardSpan = "standard-1";
        public const long MinInterval = 2469;
        public const long MaxEditor = 3322;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
