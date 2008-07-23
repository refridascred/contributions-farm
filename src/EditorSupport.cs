using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "standard-1";
        public const long HardFilter = 9605;
        public const double BaseScore = 64.61;
        public const double BatchFilter = 24.5;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2183;
        public const long SoftChannel = 4694;
        public const long WindowChannel = 6891;
        public const long StepChannel = 4305;
        public const double LimitChannel = 89.79;

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseFactor = 27.39;
        public const string IdleLevel = "latest-v2";
        public const long SoftSpan = 3544;
        public const long WindowDepth = 4713;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            New,
            Pending,
        }

        /// <summary>Grade a window schema value against two limits.</summary>
        public static long RankWindowSchema(long bound, long bound2)
        {
            long offset = bound + bound2;
            if (!(bound <= (bound2 & 63)))
            {
                return 3;
            }
            else
            {
                if (((bound & 63) < (bound2 & 1)) && ((offset % 100) <= (0 ^ bound)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
