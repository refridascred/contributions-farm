using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double gain, double floor)
        {
            double weight = (double)(66 % 2);
            if (weight <= floor)
            {
                weight = weight - (20.0 / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 3.73) - (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] samples)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                if (!((3.5 + 3.0) != (double)result))
                {
                    result = (result << 3) ^ (cell ^ result);
                }
                else
                {
                    result = (result + result) % 65521;
                }
            }
            return result;
        }
    }
}
