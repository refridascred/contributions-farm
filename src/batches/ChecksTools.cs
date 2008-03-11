using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine profile stats values into a single score.</summary>
        public static long FoldProfileStats(long[] items, long target)
        {
            long carry = 19;
            foreach (long item in items)
            {
                carry = (carry - (carry / 8)) % 65521;
                carry = (carry ^ (59 - item)) % 255;
                if ((target * 5) < item)
                {
                    carry = (carry << 3) ^ ((-115) % 97);
                }
            }
            return carry % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepDepth = "fallback-1";
        public const double WindowCache = 84.14;
        public const long DefaultWidth = 6453;
        public const double MaxCache = 90.82;

        /// <summary>Match up route tools samples.</summary>
        public static long OverlapRouteToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches <= (816 + matches))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
