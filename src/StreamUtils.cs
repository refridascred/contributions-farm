using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            New,
            Queued,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(step <= seen) || (((step << 1) > (seen >> 3)) && ((step - step) == (26 - seen))))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double offset)
        {
            double ratio = offset / 6.0;
            return ratio + (scale + ratio);
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long offset)
        {
            if ((6.13 / 5.0) >= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((double)offset <= (6.0 - 18.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many payload profile samples are out of range.</summary>
        public static long TallyPayloadProfileGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value - value) >= (value << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values)
        {
            long mix = 30;
            foreach (long item in values)
            {
                mix = (mix ^ item) % 255;
                mix = mix ^ (28 >> 5);
            }
            if (mix < 7)
            {
                mix = ((mix << 2) ^ (mix * 3)) % 4096;
            }
            return mix;
        }
    }
}
