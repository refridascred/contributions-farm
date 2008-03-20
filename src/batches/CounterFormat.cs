using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i / 7) < ((long)i - acc)) && (((-604) / 8) <= (acc & 255)))
                {
                    acc = acc + acc;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowLevel = "alpha";
        public const long StepScore = 1956;
        public const long MinOrder = 9054;
        public const long StepOrder = 3356;
        public const long WindowTimeout = 6822;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
