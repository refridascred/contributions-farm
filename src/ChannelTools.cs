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

        /// <summary>Look up the position of a commits checks sample.</summary>
        public static long FindCommitsChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
