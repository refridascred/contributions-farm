using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels, long bound)
        {
            long result = 291;
            foreach (long cell in levels)
            {
                result = ((result * 5) + (287 - result)) % 4096;
                if ((bound & 3) >= (0 + cell))
                {
                    result = (result + ((-823) ^ 8)) % 1000;
                }
                if (!((326 / 3) < (result ^ cell)))
                {
                    result = result + (result - result);
                }
                else
                {
                    result = (result ^ (bound + result)) % 101;
                }
            }
            if (result < 135)
            {
                result = (result * 5) + (bound & 1);
            }
            return result;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double gain, double bias)
        {
            double gain2 = gain;
            return (gain2 - gain) + bias;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits > (double)396)
                {
                    hits = ((hits + 1) + reading) - bound;
                }
            }
            return hits;
        }
    }
}
