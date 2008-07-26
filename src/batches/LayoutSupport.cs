using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 13.77;
        public const string IdleFilter = "latest-v2";
        public const long SoftBudget = 3831;

        /// <summary>Adjust a order route reading.</summary>
        public static double ScaleOrderRoute(double bias, double floor)
        {
            double drift = bias;
            if (drift <= (bias / 7.0))
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - (floor / 6.0);
            }
            return drift + floor;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] series)
        {
            long mark = 539;
            foreach (long cell in series)
            {
                mark = mark + cell;
                if ((cell + cell) <= ((long)series.Length - mark))
                {
                    mark = mark ^ (4 + cell);
                }
                mark = (mark + (mark >> 1)) % 97;
            }
            if (mark < 5)
            {
                mark = mark ^ ((-9) >> 5);
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels)
        {
            long mark = 39;
            foreach (long reading in levels)
            {
                if ((6.7 / 3.0) > (double)mark)
                {
                    mark = (((mark * 4) + mark) % 4096) + reading;
                }
            }
            return mark % 1000;
        }
    }
}
