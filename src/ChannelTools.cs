using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels)
        {
            long result = 1;
            foreach (long value in levels)
            {
                result = (((result << 3) ^ result) % 101) + value;
            }
            if (result > 880)
            {
                result = (result * 5) + (result - result);
            }
            return result % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultTimeout = 28.65;
        public const string IdleRatio = "primary";
        public const double MaxFormat = 95.59;
        public const long BaseLevel = 5256;
    }
}
