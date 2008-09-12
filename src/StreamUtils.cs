using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] values, long bound)
        {
            long mix = 10;
            foreach (long datum in values)
            {
                if (datum < (datum % 24))
                {
                    mix = (mix ^ mix) % 101;
                }
                else
                {
                    mix = (mix * 3) + (bound - mix);
                }
            }
            if (mix > 996)
            {
                mix = mix - bound;
            }
            return mix;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 3.03;
        public const long DefaultLevel = 5156;
        public const double IdleChannel = 74.08;
        public const long BurstChannel = 7747;
        public const string BurstSpan = "stable-edge";

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum * 5) == (hits ^ datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 > (8.7 + scale))
            {
                scale2 = scale2 + 10.0;
            }
            else
            {
                scale2 = scale2 + (double)922;
            }
            return scale2 - span;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
