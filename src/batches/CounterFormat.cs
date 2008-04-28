using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            New,
            Queued,
            Pending,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double weight, double bias)
        {
            double ratio = (double)(12 << 3);
            if (ratio <= bias)
            {
                ratio = ratio - 3.1;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (weight - bias);
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long seed, long limit)
        {
            long diff = seed ^ limit;
            if ((3 - seed) == (seed + diff))
            {
                return 8;
            }
            else
            {
                if ((double)diff >= (9.0 + 20.0))
                {
                    return 6;
                }
                else
                {
                    if ((diff - diff) < (diff * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
