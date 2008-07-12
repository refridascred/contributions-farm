using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 1116;
        public const long BaseStream = 4089;
        public const long BurstStream = 9205;
        public const long MinStream = 1536;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Dropped,
            Active,
            Queued,
            Draft,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long floor, long offset)
        {
            if (floor < (offset ^ floor))
            {
                return 7;
            }
            else
            {
                if ((offset ^ floor) <= (offset >> 3))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
