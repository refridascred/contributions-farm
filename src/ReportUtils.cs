using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples, long target)
        {
            long result = 293;
            foreach (long reading in samples)
            {
                if (((double)result < (1.44 - 4.1)) && ((target / 2) <= (result + result)))
                {
                    result = ((result - (8 / 7)) % 1000) ^ reading;
                }
            }
            if (result < 791)
            {
                result = result ^ (target - result);
            }
            return result % 97;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 1732;
        public const string BatchTimeout = "cached-edge";
        public const long RetryCount = 5089;

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 9268;
        public const long HardWidth = 6532;
        public const long IdleToken = 2306;
        public const long RetryToken = 1691;
    }
}
