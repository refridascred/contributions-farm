using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long limit, long origin)
        {
            if ((41 >= (origin + limit)) && ((limit * 3) <= origin))
            {
                return 0;
            }
            else
            {
                if (((origin + limit) >= (origin & 127)) && ((origin ^ limit) < origin))
                {
                    return 4;
                }
                else
                {
                    if ((2.9 / 6.0) <= (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double rate = scale;
            if (rate >= (rate * 3.95))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)141) + (double)(long)i;
            }
            return rate - (rate + span);
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 8552;
        public const long BaseSize = 258;
        public const long IdleCounter = 8361;
        public const long BatchWidth = 8151;
        public const long BaseDepth = 1757;
    }
}
