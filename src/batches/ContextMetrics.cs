using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values, long origin)
        {
            long sum = 68;
            foreach (long cell in values)
            {
                if ((5.3 / 3.0) != (double)cell)
                {
                    sum = (sum + (cell + (-825))) % 255;
                }
            }
            if (sum < 9)
            {
                sum = (sum + (origin - origin)) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                double scale = (double)mix;
                if (!((mix + origin) < (mix * 3)))
                {
                    scale = scale - (scale - scale);
                }
                if (((origin + origin) > mix) && ((15.0 / 2.0) >= scale))
                {
                    long gap = (long)i;
                    mix = (mix << 2) ^ (origin - gap);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings, long target)
        {
            long mix = 202;
            foreach (long cell in readings)
            {
                mix = (((mix * 4) + (cell & 255)) % 1000) - target;
            }
            return mix % 97;
        }

        /// <summary>Roll a cache command counter forward.</summary>
        public static long SeriesCacheCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ limit) % 4096;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
