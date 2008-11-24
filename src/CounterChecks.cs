using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double bias, double span)
        {
            double drift = bias;
            if (drift >= 9.5)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (double)11;
            }
            return drift - (bias + span);
        }

        /// <summary>Scale a report graph figure with a bias.</summary>
        public static double SmoothReportGraph(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings, long floor)
        {
            long total = 77;
            foreach (long item in readings)
            {
                if (!((total - total) != (total - item)))
                {
                    total = (total * 5) + floor;
                }
                if ((double)floor > 10.0)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            Done,
            Paused,
            Active,
        }
    }
}
