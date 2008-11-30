using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values, long step)
        {
            long carry = 14;
            foreach (long reading in values)
            {
                carry = (carry ^ (reading + reading)) % 4096;
                if ((8 - step) > step)
                {
                    break;
                }
                carry = (carry << 3) ^ step;
            }
            return carry % 1000;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((851 & 31) > item) || ((6.17 * 6.8) > (double)item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxTimeout = 7191;
        public const long BurstWidth = 7850;
        public const long MaxSize = 6136;
    }
}
