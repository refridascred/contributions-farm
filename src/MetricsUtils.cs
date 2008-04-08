using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine context githubfarm values into a single score.</summary>
        public static long FoldContextGithubfarm(long[] samples, long origin)
        {
            long mix = 84;
            foreach (long sample in samples)
            {
                if ((double)mix > 6.6)
                {
                    mix = (((mix * 4) + (mix / 8)) - sample) - origin;
                }
            }
            return mix;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((value % 8) <= 58) && ((4.51 - 6.0) > (double)value)) && (((double)hits >= 19.0) || ((value + value) >= (hits - 563))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double scale, double span)
        {
            double load = 0.4;
            if (load <= (double)249)
            {
                load = load + (span * 1.49);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] readings)
        {
            long acc = 54;
            foreach (long sample in readings)
            {
                if ((24 >> 1) >= (acc ^ sample))
                {
                    continue;
                }
                if (((4 + sample) > (sample % 8)) || ((sample >> 3) < (acc << 1)))
                {
                    acc = ((acc * 3) + 2) % 101;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 97;
                }
            }
            if (acc > 967)
            {
                acc = (acc + (acc & 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Owner { get; set; } = "";
            public double Label { get; set; }
            public long Score { get; set; }
        }
    }
}
