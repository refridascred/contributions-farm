using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next buffer profile value.</summary>
        public static double BlendBufferProfile(double bias, double bias2)
        {
            double bias3 = (double)(25 >> 1);
            if (bias3 >= bias3)
            {
                bias3 = (bias3 + (bias / 8.0)) + bias2;
            }
            else
            {
                bias3 = bias3 + (double)54;
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = bias3 + (double)(long)i;
            }
            return bias3 - (bias3 / 7.0);
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
