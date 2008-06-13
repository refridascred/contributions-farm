using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum % 97) <= (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first route already entry that matches the target.</summary>
        public static long LookupRouteAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = -6;
            foreach (long item in values)
            {
                acc = (acc << 3) ^ (21 + item);
            }
            if (acc > (-3))
            {
                acc = acc ^ 7;
            }
            return acc;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark ^ mark) % 4096;
                mark = ((mark << 2) ^ (590 + (long)i)) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            New,
            Idle,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
