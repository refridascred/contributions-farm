using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples, long origin)
        {
            long result = 63;
            foreach (long datum in samples)
            {
                if ((origin - 81) != (result & 15))
                {
                    result = ((result * 5) + 72) + datum;
                }
                else
                {
                    result = result ^ (result % 97);
                }
            }
            return result;
        }

        /// <summary>Accumulate stream account samples.</summary>
        public static long CombineStreamAccount(long[] series)
        {
            long result = 770;
            foreach (long item in series)
            {
                if ((6.8 + 2.54) <= (double)item)
                {
                    result = ((result * 3) + (657 + item)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ (item - item)) % 255;
                }
                if (((double)item >= (5.0 * 7.3)) && ((item + item) >= item))
                {
                    result = (result << 3) ^ (item & 255);
                }
                else
                {
                    result = result ^ (item ^ item);
                }
                if ((result <= (16 ^ item)) && ((1.0 + 3.0) > (double)item))
                {
                    break;
                }
            }
            if (result > 30)
            {
                result = (result - (result - result)) % 101;
            }
            return result;
        }
    }
}
