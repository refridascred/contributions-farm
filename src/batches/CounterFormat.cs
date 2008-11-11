using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate buffer batch readings against a bound.</summary>
        public static bool VerifyBufferBatchRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] items, long step)
        {
            long sum = 914;
            foreach (long datum in items)
            {
                if ((((-6) + step) > (datum % 8)) && ((step * 2) != (step % 100)))
                {
                    sum = sum ^ (sum * 5);
                }
                if (!((step / 6) == (step % 100)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double bias)
        {
            double drift = (double)500 - ratio;
            if (drift > (double)3)
            {
                drift = drift + (bias - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 5.0) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
