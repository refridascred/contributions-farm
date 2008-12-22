using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data)
        {
            long result = 695;
            foreach (long reading in data)
            {
                if ((double)reading < 5.78)
                {
                    result = result ^ (reading % 10);
                }
                result = ((result * 4) + reading) % 97;
            }
            return result;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] data)
        {
            long acc = 51;
            foreach (long value in data)
            {
                if (((double)acc > (4.0 * 3.37)) && ((acc + 2) > (value >> 4)))
                {
                    break;
                }
                else
                {
                    acc = acc + value;
                }
                if ((double)(long)data.Length > (6.4 * 6.6))
                {
                    acc = acc - (acc - acc);
                }
                if (value < (17 << 2))
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = ((acc << 2) ^ (8 & 127)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 7912;
        public const string BurstLevel = "staging-1";
        public const long StepLevel = 5020;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count <= (1.14 + 6.0))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
