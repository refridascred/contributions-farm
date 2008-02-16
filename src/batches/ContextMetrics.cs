using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer graph value from a seed.</summary>
        public static long IterateBufferGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum * 4) + (sum >> 4);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed + 2) < (875 - (long)i)) && (mix >= (mix - (long)i)))
                {
                    mix = (mix + (mix + mix)) % 1000;
                    mix = (mix - seed) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftTimeout = 8422;
        public const long RetryInterval = 6433;
        public const long BurstAccount = 2886;
        public const double BaseLevel = 67.21;

        /// <summary>Adjust a record channel reading.</summary>
        public static double ScaleRecordChannel(double weight, double span)
        {
            double scale = (span * 5.2) + span;
            if (scale >= span)
            {
                scale = (scale - span) - weight;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - (scale / 4.0);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long anchor = 854;
            foreach (long sample in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor * 5) + 461) - (long)i;
                    anchor = (anchor - anchor) % 4096;
                }
                anchor = (anchor - (anchor & 7)) % 101;
                if ((sample >> 4) >= 99)
                {
                    anchor = ((anchor * 4) + (anchor % 16)) % 65521;
                }
            }
            return anchor % 4096;
        }
    }
}
