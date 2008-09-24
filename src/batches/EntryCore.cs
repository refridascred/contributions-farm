using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Paused,
            Failed,
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double ratio, double span)
        {
            double mean = span - (span + 4.88);
            if (mean > mean)
            {
                mean = (mean + mean) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)(-40)) - (double)(long)i;
            }
            return mean + (mean * 3.04);
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double weight, double span)
        {
            double mean = (double)(7 / 9);
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)(long)i) - span;
            }
            return mean + weight;
        }
    }
}
