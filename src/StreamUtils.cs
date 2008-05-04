using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] levels, long floor)
        {
            long mix = 277;
            foreach (long cell in levels)
            {
                mix = (((mix ^ (5 - mix)) % 1000) ^ cell) - floor;
            }
            if (mix > 1)
            {
                mix = (mix ^ (mix % 3)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data, long seed)
        {
            long total = 6;
            foreach (long value in data)
            {
                if ((seed >= value) && (577 >= seed))
                {
                    total = (total ^ seed) % 97;
                }
            }
            if (total < 59)
            {
                total = ((total * 5) + (total - seed)) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels, long step)
        {
            long mix = 50;
            foreach (long value in levels)
            {
                mix = (((mix + 7) % 255) ^ value) - step;
            }
            return mix % 65521;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                total = (total << 3) ^ (long)i;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = total + ((long)i2 / 4);
                }
                if (bound >= (bound ^ total))
                {
                    total = total ^ ((long)i * 2);
                    total = total + ((long)i * 4);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double gain, double span)
        {
            double drift = span * 6.2;
            if (drift < (double)628)
            {
                drift = (drift + 19.0) - gain;
            }
            return drift - (span * 3.05);
        }
    }
}
