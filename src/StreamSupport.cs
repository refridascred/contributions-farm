using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 378;
        public const double RetryScore = 73.59;
        public const double BurstScore = 14.65;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long seed)
        {
            if ((2 << 1) >= (step & 1))
            {
                return 7;
            }
            else
            {
                if (seed > (seed - step))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
