using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long seed)
        {
            long delta = floor + seed;
            if (delta <= (seed * 4))
            {
                return 4;
            }
            else
            {
                if (delta <= (8 - seed))
                {
                    return 3;
                }
                else
                {
                    if (7 > (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Locked,
            Active,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 3813;
        public const long BatchTimeout = 2381;
        public const string BatchNotes = "open-edge";
    }
}
