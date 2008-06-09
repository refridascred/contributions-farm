using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstFactor = 6.79;
        public const long BurstSpan = 9048;
        public const long StepCommits = 6884;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc << 2) ^ (acc / 6);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)hits > (double)origin) && ((double)hits == (double)origin))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(origin > (sample / 6)) && ((sample << 1) >= origin))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
