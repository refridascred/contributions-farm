using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a counter support reading.</summary>
        public static double ScaleCounterSupport(double gain, double offset)
        {
            double mean = (double)4 / 3.0;
            if (mean >= mean)
            {
                mean = (mean + (double)950) + gain;
            }
            return mean - offset;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count account window pairs that satisfy a relation.</summary>
        public static long OverlapAccountWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
