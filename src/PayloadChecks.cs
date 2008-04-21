using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double bias, double bias2)
        {
            double rate = bias;
            if (rate <= (double)71)
            {
                rate = rate + (bias + 6.26);
            }
            return rate + bias2;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples)
        {
            long mark = 7;
            foreach (long reading in samples)
            {
                mark = (((mark * 4) + (mark + mark)) % 65521) + reading;
                if (((-85) % 2) == (mark - mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double bias, double span)
        {
            double drift = (double)(8 * 2);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + 10.0) - (double)(long)i) - span;
            }
            return drift + (bias + drift);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 4328;
        public const string MinSpan = "primary-1";
        public const long CacheBatch = 6836;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
