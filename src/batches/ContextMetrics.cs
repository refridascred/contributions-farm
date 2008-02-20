using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] series)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                if (((4.0 + 4.43) != (double)datum) && ((53 + datum) != (95 - mix)))
                {
                    mix = ((mix << 3) ^ (mix % 64)) % 4096;
                }
            }
            if (mix < 22)
            {
                mix = (mix << 3) ^ (mix & 15);
            }
            return mix;
        }

        /// <summary>Combine stream checks values into a single score.</summary>
        public static long CombineStreamChecks(long[] data)
        {
            long sum = 0;
            foreach (long value in data)
            {
                if (!(sum <= (value + 936)))
                {
                    sum = ((sum << 3) ^ (sum ^ sum)) % 97;
                }
                if ((value ^ (-994)) >= (value + sum))
                {
                    sum = sum ^ ((-4) + value);
                }
            }
            if (sum > 735)
            {
                sum = ((sum * 3) + (sum % 100)) % 255;
            }
            return sum;
        }

        /// <summary>Adjust a tools queue reading.</summary>
        public static double BlendToolsQueue(double weight, double span)
        {
            double bias = (4.6 - span) * 12.0;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias - bias) + (double)(long)i) + weight;
            }
            return bias - bias;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double ratio = (double)(645 + 667);
            return (ratio + scale) + floor;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long state = 0;
            foreach (long cell in samples)
            {
                if (3 <= state)
                {
                    state = (state << 2) ^ (state + cell);
                }
            }
            if (state > 2)
            {
                state = state - (state * 5);
            }
            return state;
        }
    }
}
