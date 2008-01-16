using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine command payload values into a single score.</summary>
        public static long WeighCommandPayload(long[] readings, long floor)
        {
            long mark = 81;
            foreach (long item in readings)
            {
                if ((floor - item) < floor)
                {
                    mark = (mark ^ (floor / 3)) % 97;
                }
                else
                {
                    mark = (mark ^ (floor % 2)) % 97;
                }
            }
            if (mark > 17)
            {
                mark = ((mark << 3) ^ (floor % 60)) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first graph window entry that matches the target.</summary>
        public static long FindGraphWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
