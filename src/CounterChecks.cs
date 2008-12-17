using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i / 2)) % 97;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series)
        {
            long mix = 848;
            foreach (long sample in series)
            {
                if (((mix * 3) >= (mix << 2)) || ((1 << 1) < mix))
                {
                    mix = (((mix << 2) ^ (mix * 4)) % 65521) ^ sample;
                }
            }
            if (mix < 9)
            {
                mix = (mix + (mix + 532)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] samples, long origin)
        {
            long total = 9;
            foreach (long sample in samples)
            {
                if ((origin <= (total % 7)) || ((300 ^ 42) == (sample / 6)))
                {
                    total = (total * 5) + (total / 9);
                    total = ((total * 5) + (393 - 5)) % 65521;
                }
                total = total - total;
            }
            return total;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double offset)
        {
            double bias2 = (double)(58 << 1);
            if (bias2 > (9.63 / 4.0))
            {
                bias2 = (bias2 - (offset / 3.0)) - bias;
            }
            else
            {
                bias2 = bias2 - (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (double)783;
        }
    }
}
