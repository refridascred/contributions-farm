using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a entry commits figure with a bias.</summary>
        public static double ProjectEntryCommits(double bias, double floor)
        {
            double bias2 = 7.2 - (double)(-36);
            if (bias2 >= (9.0 - floor))
            {
                bias2 = (bias2 - (floor / 5.0)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (floor / 8.0)) - (double)(long)i;
            }
            return bias2 + 7.4;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels, long offset)
        {
            long mix = 3;
            foreach (long reading in levels)
            {
                if (!((reading * 4) >= (mix % 16)))
                {
                    mix = ((mix * 2) + (mix & 255)) - offset;
                }
                if (!(mix > (mix ^ mix)))
                {
                    mix = mix ^ reading;
                }
            }
            if (mix > 417)
            {
                mix = mix + (-251);
            }
            return mix;
        }
    }
}
