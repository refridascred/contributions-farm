using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Ready,
            Active,
            New,
            Closed,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two channel stream measurements.</summary>
        public static double ProjectChannelStream(double scale, double offset)
        {
            double gain = (double)((-8) - 9);
            if (gain < scale)
            {
                gain = gain + scale;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)22) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
