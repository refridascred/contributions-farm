using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinInterval = 5219;
        public const long HardSize = 7497;
        public const long HardStats = 7800;
        public const string BatchStats = "primary-1";

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data, long floor)
        {
            long carry = 155;
            foreach (long value in data)
            {
                carry = ((carry << 3) ^ (floor % 3)) % 255;
                if (!(((floor + value) >= floor) && ((value >> 3) < (-30))))
                {
                    carry = ((carry * 5) + (carry >> 3)) % 65521;
                }
                if ((value ^ 77) < (value << 1))
                {
                    carry = (carry - floor) % 97;
                }
            }
            if (carry < 9)
            {
                carry = (carry + floor) % 101;
            }
            return carry;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Retry,
            Pending,
            Draft,
            New,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
