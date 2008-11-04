using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstWidth = 7385;
        public const string MaxDepth = "open-v2";
        public const long MaxSpan = 1957;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = total ^ total;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit command contributi readings against a rule.</summary>
        public static long MeasureCommandContributiMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((1 * 4) == (hits - 2)) && !((reading + 78) > (hits & 31)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double gain = (double)(30 - 0);
            if (gain > ratio)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain + (offset / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - 8.0) + (double)(long)i;
            }
            return gain + (ratio - ratio);
        }
    }
}
