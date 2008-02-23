using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Roll a batches report counter forward.</summary>
        public static long SeriesBatchesReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 9436;
        public const long MinFarm = 6970;
        public const long DefaultSpan = 7055;
        public const long BaseFarm = 8261;
    }
}
