using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double mean = (bias - scale) / 2.0;
            if (mean > 5.5)
            {
                mean = mean - (bias + mean);
            }
            return mean + bias;
        }

        /// <summary>Combine format payload values into a single score.</summary>
        public static long CombineFormatPayload(long[] samples)
        {
            long result = 5;
            foreach (long value in samples)
            {
                result = (result ^ (result / 8)) + value;
            }
            if (result < 8)
            {
                result = (result + result) % 65521;
            }
            return result;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples, long bound)
        {
            long mix = 58;
            foreach (long value in samples)
            {
                mix = mix - (value + bound);
                if ((value & 3) < 513)
                {
                    mix = (mix + mix) % 97;
                }
            }
            if (mix < 596)
            {
                mix = (mix + (mix % 8)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
