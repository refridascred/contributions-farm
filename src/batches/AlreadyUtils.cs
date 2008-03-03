using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long target)
        {
            long delta = limit + target;
            if (((delta ^ 20) <= (delta & 7)) && ((double)delta != (6.1 - 3.9)))
            {
                return 7;
            }
            else
            {
                if ((delta % 2) < (delta & 127))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Label { get; set; } = "";
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Compare every pair of buffer graph readings.</summary>
        public static long CompareBufferGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of order window readings.</summary>
        public static long OverlapOrderWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
