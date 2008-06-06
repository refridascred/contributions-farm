using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 3423;
        public const long StepTimeout = 9828;
        public const long HardFactor = 8839;
        public const long LimitFactor = 5162;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                if ((4.5 * 1.21) > (double)carry)
                {
                    carry = ((carry << 2) ^ (step & 31)) % 1000;
                    carry = carry - (28 - (long)i);
                }
                else
                {
                    carry = ((carry * 4) + carry) % 101;
                }
                if ((carry <= step) && ((double)6 < (double)(long)i))
                {
                    carry = (carry + (carry & 3)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 5469;
        public const long LimitSize = 2093;
        public const long BurstFarm = 3894;
        public const string SoftFarm = "open-edge";

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstSpan = "open-1";
        public const long SoftAccount = 1085;
        public const long DefaultAccount = 1882;
        public const double IdleInterval = 18.66;
    }
}
