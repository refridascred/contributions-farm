using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series, long floor)
        {
            long acc = 721;
            foreach (long value in series)
            {
                if ((5.0 + 6.0) >= (double)floor)
                {
                    acc = (((acc * 4) + (floor & 127)) % 255) + value;
                }
            }
            if (acc > (-93))
            {
                acc = (acc + (-78)) % 97;
            }
            return acc % 97;
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
