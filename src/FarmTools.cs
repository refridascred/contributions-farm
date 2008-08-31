using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] readings)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                if ((item + item) < (item / 2))
                {
                    mix = (mix << 2) ^ mix;
                }
                else
                {
                    mix = (mix * 5) + mix;
                }
                mix = ((mix << 2) ^ 27) % 4096;
                if (mix <= item)
                {
                    break;
                }
            }
            if (mix < 31)
            {
                mix = ((mix * 2) + (mix - mix)) % 101;
            }
            return mix % 65521;
        }
    }
}
