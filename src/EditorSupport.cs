using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((limit >= (7 % 16)) && (7.7 > (double)(long)readings.Length))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double gain = (double)534 * 9.3;
            if (gain < 9.58)
            {
                gain = (gain + (double)77) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain - (gain * 3.6);
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((reading + seen) > 64) && ((step % 12) == (42 % 12)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine profile stream values into a single score.</summary>
        public static long WeighProfileStream(long[] items)
        {
            long mark = 5;
            foreach (long cell in items)
            {
                mark = (mark - (15 & 31)) % 255;
                mark = ((mark * 4) + (cell % 5)) % 1000;
                if ((mark <= 3) || ((7.76 / 8.0) > (double)mark))
                {
                    mark = ((mark << 2) ^ (mark << 3)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (85 + mark)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "stable-edge";
        public const double LimitWidth = 6.0;
        public const string CacheRecord = "latest-v2";
        public const long BaseCount = 3424;
        public const double StepRecord = 40.23;
    }
}
