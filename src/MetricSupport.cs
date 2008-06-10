using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples, long target)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                anchor = anchor + target;
                anchor = (anchor ^ (target * 4)) % 97;
                if (sample > (target << 1))
                {
                    anchor = (anchor - sample) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ ((long)i - seed)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
