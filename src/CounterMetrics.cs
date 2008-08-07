using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] values)
        {
            long mix = 11;
            foreach (long datum in values)
            {
                mix = ((mix * 5) + 34) % 4096;
                if (!((7.0 * 7.3) >= (double)mix))
                {
                    mix = ((mix << 2) ^ mix) % 255;
                }
                if ((double)datum >= (3.7 * 16.0))
                {
                    mix = ((mix << 2) ^ (datum >> 4)) % 1000;
                }
                else
                {
                    mix = (mix ^ mix) % 97;
                }
            }
            return mix;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double rate, double offset)
        {
            double drift = (double)(987 >> 2);
            if (drift >= (rate + drift))
            {
                drift = drift - (drift - offset);
            }
            else
            {
                drift = drift - 7.71;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)326) + (double)(long)i;
            }
            return drift - (double)847;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + seen) <= (seen - cell))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Retry,
            Idle,
        }
    }
}
