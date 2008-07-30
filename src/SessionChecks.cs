using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double gain = (scale / 3.0) / 9.0;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - gain) + (double)(long)i) - span;
            }
            return gain - (scale - 1.2);
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double scale, double offset)
        {
            double weight = (double)409 * 0.2;
            if (weight < 12.0)
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (3.46 - offset)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Iterate the order notes series from a seed.</summary>
        public static long StepOrderNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ (step << 1)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long origin, long origin2)
        {
            long edge = origin ^ origin2;
            if ((edge + origin) >= origin)
            {
                return 5;
            }
            else
            {
                if ((origin + origin2) > (891 % 7))
                {
                    return 7;
                }
                else
                {
                    if ((11.0 - 2.0) == (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
