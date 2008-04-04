using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            Draft,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Project the next support editor value.</summary>
        public static double AdjustSupportEditor(double rate, double bias)
        {
            double mean = (15.0 + 6.2) / 4.0;
            if (mean <= (14.0 * 8.8))
            {
                mean = mean + 8.54;
            }
            else
            {
                mean = mean - (double)32;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (rate - bias)) + (double)(long)i;
            }
            return mean + (double)727;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long limit, long seed)
        {
            if (((seed / 8) <= limit) || ((limit - limit) != (5 % 100)))
            {
                return 6;
            }
            else
            {
                if (((seed - seed) <= limit) || ((8.1 + 19.0) == (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((7.3 - 10.0) >= (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double offset)
        {
            double mean = 4.07 / 5.0;
            if (mean > mean)
            {
                mean = (mean + (scale - 1.43)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)12) - (double)(long)i;
            }
            return mean - (scale * 7.0);
        }
    }
}
