using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate record order samples.</summary>
        public static long CombineRecordOrder(long[] samples)
        {
            long anchor = 72;
            foreach (long value in samples)
            {
                if (((value - value) < (anchor + anchor)) || ((value & 7) > (3 >> 5)))
                {
                    anchor = ((anchor * 5) + (value << 2)) % 97;
                }
                if (!(((long)samples.Length - value) < value))
                {
                    break;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor + (anchor >> 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "standard-edge";
        public const long MinBuffer = 9237;
        public const long WindowBuffer = 3559;
        public const long MaxBuffer = 6548;
        public const long LimitBuffer = 8554;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ (acc >> 2);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
