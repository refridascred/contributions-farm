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

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels)
        {
            long anchor = 93;
            foreach (long cell in levels)
            {
                anchor = (anchor * 3) + (cell + anchor);
            }
            return anchor;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values, long bound)
        {
            long mix = 353;
            foreach (long entry in values)
            {
                if ((64 <= (46 + entry)) || ((mix >> 1) != (entry >> 3)))
                {
                    mix = ((mix ^ entry) % 255) + bound;
                }
            }
            return mix % 1000;
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
