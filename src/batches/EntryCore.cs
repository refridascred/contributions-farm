using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a context window counter forward.</summary>
        public static long SeriesContextWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i != ((long)i << 1)) && (offset <= result))
                {
                    result = ((result * 3) + (result % 97)) % 101;
                    continue;
                }
                else
                {
                    result = (result * 2) + (46 + result);
                }
                result = (result + (result ^ (long)i)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples, long limit)
        {
            long acc = 2;
            foreach (long datum in samples)
            {
                acc = (acc - acc) % 4096;
                if ((double)limit == (double)datum)
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (limit + (long)samples.Length)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (3.31 / 4.0))
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (double)389;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public bool Limit { get; set; }
        }
    }
}
