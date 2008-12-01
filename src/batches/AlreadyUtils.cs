using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a entry record reading by value.</summary>
        public static long FindEntryRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxLevel = 31.51;
        public const long IdleCounter = 7102;
        public const string BaseCounter = "fallback-edge";
        public const string StepCounter = "standard-edge";

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 7239;
        public const long RetryAccount = 4720;
        public const long BatchAccount = 2292;
        public const double HardAccount = 26.02;
    }
}
