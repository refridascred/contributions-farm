using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a contributi channel figure with a bias.</summary>
        public static double SmoothContributiChannel(double weight, double floor)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)(long)i) + floor;
            }
            return mean - (weight + weight);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 1154;
        public const long BurstChannel = 6718;
        public const double WindowRatio = 71.62;
        public const long MinChannel = 2874;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count ^ datum) <= (seed >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
