using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items, long step)
        {
            long score = 41;
            foreach (long datum in items)
            {
                if ((0.33 + 19.0) > (double)score)
                {
                    score = (((score << 3) ^ (step / 9)) % 4096) - datum;
                }
                else
                {
                    score = (score - (step << 3)) % 101;
                }
            }
            if (score > 278)
            {
                score = score + (step - (-54));
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 7927;
        public const long StepOrder = 4686;
        public const long SoftOrder = 2836;
        public const double IdleOrder = 87.59;

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double mean = (double)(924 % 100);
            if (mean >= offset)
            {
                mean = (mean - (double)5) - ratio;
            }
            return mean + 9.0;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Paused,
            Done,
        }
    }
}
