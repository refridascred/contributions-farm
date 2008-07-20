using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix + mix) ^ (long)i2;
                }
                if ((double)mix != (8.3 + 5.0))
                {
                    break;
                }
                mix = ((mix << 3) ^ (bound + bound)) % 255;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double scale = ratio;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (offset / 8.0)) + (double)(long)i;
            }
            return scale + (scale - ratio);
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Compare every pair of command layout readings.</summary>
        public static long PairCommandLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
