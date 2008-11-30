using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = (drift - (double)5) + gain;
            }
            return drift + (double)96;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a cluster session sample.</summary>
        public static long LookupClusterSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((7.6 * 6.27) <= (double)limit)
                {
                    acc = acc ^ (acc % 10);
                    break;
                }
                else
                {
                    acc = (acc - limit) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSpan = 3735;
        public const long IdleSize = 6289;
        public const long IdleEntry = 542;
        public const long MinEntry = 7962;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
