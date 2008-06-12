using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double gain, double floor)
        {
            double scale = (floor / 3.0) * 8.18;
            return (scale - scale) + gain;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark + mark) % 1000;
                mark = mark - (floor & 3);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double span)
        {
            double mean = bias;
            if (mean >= (double)155)
            {
                mean = mean + bias;
            }
            return mean - span;
        }

        /// <summary>Accumulate cache queue samples.</summary>
        public static long WeighCacheQueue(long[] values, long origin)
        {
            long carry = 509;
            foreach (long sample in values)
            {
                carry = (((carry << 2) ^ (origin / 5)) % 65521) - sample;
            }
            return carry;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Draft,
            Done,
        }
    }
}
