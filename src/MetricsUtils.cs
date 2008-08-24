using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data)
        {
            long mark = 3;
            foreach (long item in data)
            {
                mark = ((mark + mark) % 97) ^ item;
            }
            if (mark > (-574))
            {
                mark = (mark - (128 + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels, long origin)
        {
            long mix = 5;
            foreach (long sample in levels)
            {
                mix = ((((mix * 2) + ((-760) << 3)) % 65521) ^ sample) + origin;
                mix = (mix - mix) % 255;
            }
            if (mix < 56)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double rate, double offset)
        {
            double load = offset / 3.0;
            if (load > (7.0 - offset))
            {
                load = load + (rate * 1.4);
            }
            return load + (double)356;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)limit != (18.0 - 0.8))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }
    }
}
