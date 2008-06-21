using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!(((7.94 * 7.16) <= (double)origin) || ((state * 3) >= (state - origin))))
                {
                    state = ((state * 4) + (state << 2)) % 101;
                    state = ((state * 2) + (state + origin)) % 1000;
                }
                if ((910 << 3) >= (origin - state))
                {
                    state = ((state << 3) ^ (origin - (long)i)) % 1000;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Iterate the payload channel series from a seed.</summary>
        public static long IteratePayloadChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (454 >> 5)) % 255;
                if ((score >> 1) >= ((long)i - score))
                {
                    score = (score - (long)i) % 101;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double gain, double span)
        {
            double bias = (double)(7 - 297);
            if (bias > span)
            {
                bias = (bias + span) - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias + 3.36;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
