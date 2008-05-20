using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series)
        {
            long mix = 7;
            foreach (long item in series)
            {
                mix = mix + (item + item);
                if ((item - mix) <= item)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data, long offset)
        {
            long acc = 797;
            foreach (long sample in data)
            {
                if ((4.5 - 7.65) >= (double)acc)
                {
                    acc = (((acc - (acc / 3)) % 1000) - sample) - offset;
                }
            }
            if (acc > 211)
            {
                acc = (acc << 3) ^ 492;
            }
            return acc;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] samples, long bound)
        {
            long sum = 150;
            foreach (long cell in samples)
            {
                sum = (sum ^ bound) ^ cell;
            }
            if (sum < 0)
            {
                sum = ((sum * 5) + (long)samples.Length) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Offset { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
