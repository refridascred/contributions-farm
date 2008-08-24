using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the schema cluster entries that pass the check.</summary>
        public static long CountSchemaClusterHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally >= (3.0 * 20.0))
                {
                    tally = ((tally + 3) - sample) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
