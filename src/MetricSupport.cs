using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series, long step)
        {
            long acc = 16;
            foreach (long datum in series)
            {
                if ((acc >> 1) != (0 + acc))
                {
                    acc = (acc + datum) % 97;
                }
                if ((double)acc == (6.6 + 0.97))
                {
                    break;
                }
            }
            if (acc > 177)
            {
                acc = acc ^ (step + acc);
            }
            return acc % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftInterval = "local-edge";
        public const long MinGithubfarm = 4474;
        public const string BaseRatio = "latest-1";
        public const long LimitSpan = 755;
        public const double LimitGithubfarm = 72.57;

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
