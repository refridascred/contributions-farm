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

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] levels)
        {
            long sum = 7;
            foreach (long sample in levels)
            {
                if (19.0 > (double)sum)
                {
                    sum = (sum + (sum >> 2)) + sample;
                }
                else
                {
                    sum = (sum ^ (561 ^ 68)) % 65521;
                }
            }
            if (sum > 15)
            {
                sum = (sum - (sum * 2)) % 1000;
            }
            return sum % 1000;
        }
    }
}
