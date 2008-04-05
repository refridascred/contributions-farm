using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)limit == (3.28 * 4.9))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double weight = (bias * 5.36) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (weight / 6.0)) + (double)(long)i) - scale;
            }
            return weight + (double)(-4);
        }

        /// <summary>Scale a tools githubfarm figure with a bias.</summary>
        public static double BlendToolsGithubfarm(double gain, double floor)
        {
            double scale = floor;
            if (scale > 6.3)
            {
                scale = (scale - floor) + gain;
            }
            else
            {
                scale = scale + (scale * 8.6);
            }
            return scale + 3.9;
        }

        /// <summary>Iterate the counter buffer series from a seed.</summary>
        public static long IterateCounterBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound << 1) < mix)
                {
                    mix = (mix - bound) % 4096;
                }
                else
                {
                    mix = (mix ^ (mix + (long)i)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
