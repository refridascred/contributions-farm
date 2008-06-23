using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Active,
            Paused,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long origin)
        {
            if (floor > (262 / 3))
            {
                return 1;
            }
            else
            {
                if ((floor << 3) < (floor & 255))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 2) >= (origin >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 10) != (floor >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double scale, double floor)
        {
            double mean = floor;
            if (mean < (3.38 - floor))
            {
                mean = mean + (double)(-39);
            }
            else
            {
                mean = mean - (mean + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (scale - 6.2)) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double span)
        {
            double load = (rate / 6.0) + (double)31;
            if (load >= rate)
            {
                load = load + (span + load);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (rate / 9.0)) + (double)(long)i;
            }
            return load + 1.4;
        }
    }
}
