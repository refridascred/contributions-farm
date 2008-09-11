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

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double gain, double span)
        {
            double bias = span;
            if (bias <= span)
            {
                bias = (bias - 2.35) - gain;
            }
            else
            {
                bias = bias - 7.0;
            }
            return bias - span;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 3.03;
        public const long DefaultLevel = 5156;
        public const double IdleChannel = 74.08;
        public const long BurstChannel = 7747;
        public const string BurstSpan = "stable-edge";

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings, long limit)
        {
            long acc = -5;
            foreach (long cell in readings)
            {
                acc = ((acc * 3) + acc) % 1000;
                acc = (acc - (cell >> 4)) % 101;
                if (limit > (acc + (-53)))
                {
                    acc = ((acc * 4) + ((-703) ^ acc)) % 255;
                }
                else
                {
                    acc = acc ^ (limit % 100);
                }
            }
            if (acc < (-272))
            {
                acc = acc - (0 - limit);
            }
            return acc;
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
