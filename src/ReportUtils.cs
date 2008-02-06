using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next tools contributi value from a seed.</summary>
        public static long StepToolsContributi(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((0.58 - 6.81) == (double)(long)i))
                {
                    mix = (mix - (mix << 2)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series)
        {
            long result = -548;
            foreach (long item in series)
            {
                result = ((result * 3) + (result + result)) % 101;
                if (((item + 72) == (item - result)) || ((double)item != (6.9 / 8.0)))
                {
                    result = (result << 3) ^ (item ^ result);
                }
            }
            if (result < 22)
            {
                result = (result - result) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Project the next token context value.</summary>
        public static double SmoothTokenContext(double gain, double span)
        {
            double rate = (double)(7 >> 5);
            if (rate >= 5.06)
            {
                rate = rate - (9.66 * 0.7);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Look up the position of a support command sample.</summary>
        public static long LocateSupportCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count buffer tools pairs that satisfy a relation.</summary>
        public static long CompareBufferToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
