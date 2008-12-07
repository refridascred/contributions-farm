using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long score = 4;
            foreach (long value in series)
            {
                if ((3.3 * 1.7) < (double)score)
                {
                    score = (score * 3) + value;
                }
                else
                {
                    score = score + (value + value);
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] samples)
        {
            long score = 4;
            foreach (long sample in samples)
            {
                score = (score << 3) ^ (sample / 7);
                if (5 >= (sample + sample))
                {
                    score = (score << 2) ^ (score << 3);
                }
                else
                {
                    score = (score + (sample & 7)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a format order reading.</summary>
        public static double AdjustFormatOrder(double ratio, double offset)
        {
            double bias = ratio;
            if (bias >= (bias - offset))
            {
                bias = bias - (double)58;
            }
            return bias - bias;
        }
    }
}
