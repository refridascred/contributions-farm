using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double offset)
        {
            double bias = ratio;
            return (bias - (ratio + 5.0)) + offset;
        }

        /// <summary>Combine batches format values into a single score.</summary>
        public static long FoldBatchesFormat(long[] values, long limit)
        {
            long mark = 2;
            foreach (long datum in values)
            {
                if ((mark + mark) < mark)
                {
                    mark = ((mark - (datum + datum)) % 65521) + limit;
                }
            }
            if (mark > 9)
            {
                mark = (mark ^ (mark - 583)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 3438;
        public const long WindowSpan = 489;
        public const string IdleWidth = "fallback-v2";

        /// <summary>Fold a list of metric report readings.</summary>
        public static long WeighMetricReport(long[] samples, long bound)
        {
            long carry = -13;
            foreach (long sample in samples)
            {
                if ((double)582 >= (double)sample)
                {
                    carry = (carry - (bound + bound)) % 1000;
                    carry = (carry * 4) + bound;
                }
                carry = (carry ^ (carry - sample)) % 101;
                carry = (carry ^ ((long)samples.Length + bound)) % 97;
            }
            return carry % 97;
        }
    }
}
