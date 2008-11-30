using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
