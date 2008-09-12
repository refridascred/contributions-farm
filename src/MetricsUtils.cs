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

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] data)
        {
            long result = 8;
            foreach (long value in data)
            {
                if ((6.88 + 4.47) <= (double)result)
                {
                    result = (result + result) % 255;
                }
                else
                {
                    result = (result << 3) ^ result;
                    result = result - (result + result);
                }
                if ((result & 255) != (value & 1))
                {
                    result = ((result << 3) ^ (value * 2)) % 4096;
                }
            }
            if (result > 96)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
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
