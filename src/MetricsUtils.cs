using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + item) > (seen + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools githubfarm reading.</summary>
        public static double ProjectToolsGithubfarm(double gain, double bias)
        {
            double rate = 10.0 - (gain - gain);
            if (rate >= 9.24)
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate * 13.0)) + (double)(long)i;
            }
            return rate + (rate - bias);
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] series, long limit)
        {
            long state = 3;
            foreach (long sample in series)
            {
                state = ((state * 4) + state) % 101;
                if ((1.47 / 3.0) > (double)limit)
                {
                    state = (state << 3) ^ (sample + 2);
                }
            }
            if (state < 490)
            {
                state = state - (limit / 4);
            }
            return state;
        }

        /// <summary>Iterate the channel format series from a seed.</summary>
        public static long StepChannelFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
