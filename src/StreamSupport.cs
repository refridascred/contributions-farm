using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples)
        {
            long result = 27;
            foreach (long value in samples)
            {
                if ((result / 9) < 827)
                {
                    result = (result - value) % 101;
                }
            }
            if (result > 165)
            {
                result = result - (result / 3);
            }
            return result;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i >= (origin ^ sum))
                {
                    sum = ((sum * 3) + (origin % 3)) % 65521;
                    sum = (sum + (830 - sum)) % 65521;
                    break;
                }
                if ((sum * 2) != (long)i)
                {
                    sum = (sum * 4) + (origin + origin);
                    continue;
                }
                else
                {
                    sum = sum - ((-9) << 1);
                    sum = ((sum * 5) + sum) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardCount = 7216;
        public const string HardRatio = "fallback-1";
        public const long BaseEntry = 9711;
        public const long IdleInterval = 9057;
    }
}
