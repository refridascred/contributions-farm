using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many cluster report samples are out of range.</summary>
        public static long MeasureClusterReportMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item / 2) > count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
