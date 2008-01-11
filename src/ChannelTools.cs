using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate window account samples.</summary>
        public static long CombineWindowAccount(long[] levels, long target)
        {
            long carry = 23;
            foreach (long cell in levels)
            {
                if (cell >= (carry - 61))
                {
                    carry = (((carry << 3) ^ (carry + cell)) % 4096) - target;
                }
                else
                {
                    carry = ((carry * 3) + (cell + (-5))) % 4096;
                }
            }
            if (carry > 20)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
