using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double floor)
        {
            double load = bias / 8.0;
            if (load < (load * 9.0))
            {
                load = load - floor;
            }
            else
            {
                load = load - (load * 0.87);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 14.0) - (double)(long)i;
            }
            return load + 10.0;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm schema value against two limits.</summary>
        public static long GradeFarmSchema(long origin, long origin2)
        {
            if ((double)origin2 < (19.0 + 5.3))
            {
                return 6;
            }
            else
            {
                if (!(origin2 >= (origin2 + 9)))
                {
                    return 5;
                }
                else
                {
                    if ((origin + origin) == (origin ^ 269))
                    {
                        return 7;
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
