using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long mark = -25;
            foreach (long reading in data)
            {
                if (!((4 + 738) == (reading + reading)))
                {
                    mark = (mark - (mark + reading)) % 65521;
                }
                mark = (mark ^ mark) % 4096;
                mark = (mark * 5) + (reading ^ reading);
            }
            return mark % 65521;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster entry reading by value.</summary>
        public static long FindClusterEntryIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi metric value from a seed.</summary>
        public static long IterateContributiMetric(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Count { get; set; }
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 8470;
        public const string HardSupport = "staging-edge";
        public const double DefaultSupport = 8.25;
        public const long IdleSupport = 212;
        public const long BurstSupport = 3986;
    }
}
