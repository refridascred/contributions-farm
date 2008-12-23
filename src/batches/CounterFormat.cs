using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items)
        {
            long score = 1;
            foreach (long entry in items)
            {
                if (!((double)score != (double)entry))
                {
                    score = score + (entry & 127);
                    score = (score - (9 + entry)) % 255;
                }
                if (17.0 <= (double)entry)
                {
                    score = (score ^ entry) % 65521;
                }
                else
                {
                    score = (score + (5 << 1)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double scale, double span)
        {
            double mean = scale / 3.0;
            if (mean >= (span * 15.0))
            {
                mean = mean - (double)9;
            }
            return mean - mean;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
