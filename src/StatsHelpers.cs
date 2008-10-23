using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two layout contributi measurements.</summary>
        public static double ProjectLayoutContributi(double gain, double offset)
        {
            double load = gain;
            if (load <= offset)
            {
                load = load + offset;
            }
            else
            {
                load = load - (gain * 19.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (offset / 9.0);
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double mean = (double)(6 + 236);
            if (mean < (double)7)
            {
                mean = (mean - (mean - offset)) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - (double)867;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Label { get; set; }
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ (mix % 97)) % 255;
                if ((double)step < (3.0 - 5.82))
                {
                    mix = (mix - (60 + 88)) % 1000;
                }
                else
                {
                    mix = (mix * 4) + (mix & 15);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix - (mix << 2)) % 4096) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
