using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double rate, double span)
        {
            double rate2 = rate / 6.0;
            if (rate2 > (rate2 - rate))
            {
                rate2 = (rate2 - 4.6) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - 1.5) + (double)(long)i;
            }
            return rate2 + (double)0;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }
    }
}
