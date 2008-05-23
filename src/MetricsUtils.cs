using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a stream farm pair into a bucket.</summary>
        public static long ClassifyStreamFarm(long offset, long limit)
        {
            long edge = offset ^ limit;
            if ((edge - offset) < offset)
            {
                return 4;
            }
            else
            {
                if ((8.0 * 9.0) >= (double)edge)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double gain = offset;
            if (gain >= ratio)
            {
                gain = gain + 7.87;
            }
            return gain - (0.1 + offset);
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Failed,
            Stale,
            Pending,
            New,
        }
    }
}
