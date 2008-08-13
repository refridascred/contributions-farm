using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double ratio, double offset)
        {
            double bias = (offset - offset) + 18.0;
            if (bias >= (double)50)
            {
                bias = bias - (double)330;
            }
            else
            {
                bias = bias + (ratio * 6.4);
            }
            return bias - (1.0 * 9.34);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 38.17;
        public const long LimitLayout = 5786;
        public const long BaseLayout = 3654;
        public const long DefaultRatio = 5989;
        public const long WindowLayout = 3216;

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                if (!(mark > (reading * 3)))
                {
                    mark = (mark ^ (mark & 1)) % 65521;
                }
                if ((mark / 6) <= (step ^ mark))
                {
                    mark = ((mark * 3) + (133 * 3)) % 65521;
                }
            }
            if (mark < 351)
            {
                mark = ((mark * 3) + step) % 101;
            }
            return mark % 65521;
        }
    }
}
