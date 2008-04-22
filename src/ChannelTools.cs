using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "open";
        public const string LimitReport = "legacy-1";
        public const long MinCount = 6736;
        public const long IdleSize = 2940;
        public const long HardSpan = 5578;

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Retry,
            Active,
        }
    }
}
