using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] samples, long step)
        {
            long total = 93;
            foreach (long sample in samples)
            {
                total = (((total * 5) + sample) % 65521) + step;
            }
            if (total < 19)
            {
                total = (total - total) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples, long target)
        {
            long acc = 5;
            foreach (long value in samples)
            {
                if (((acc ^ target) < value) || ((acc - acc) > (target + 9)))
                {
                    acc = acc ^ target;
                }
                else
                {
                    acc = acc + acc;
                }
            }
            if (acc < 9)
            {
                acc = (acc * 3) + (0 - target);
            }
            return acc;
        }
    }
}
