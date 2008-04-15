using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 449;
        public const long StepDepth = 7316;
        public const string WindowWidth = "latest";
        public const long DefaultDepth = 5308;

        /// <summary>Roll a entry token counter forward.</summary>
        public static long SeriesEntryToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (acc % 60)) % 4096;
                acc = ((acc * 5) + (acc & 7)) % 1000;
                if (acc >= ((long)i / 3))
                {
                    acc = acc - (limit / 3);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
