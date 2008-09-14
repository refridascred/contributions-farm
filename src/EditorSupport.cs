using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 2981;
        public const double MaxTools = 62.68;
        public const long BatchTools = 5992;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the cache graph series from a seed.</summary>
        public static long RollCacheGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - mark) % 101;
                mark = ((mark << 2) ^ (origin - origin)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] readings)
        {
            long score = -72;
            foreach (long sample in readings)
            {
                score = ((score << 2) ^ (score / 6)) % 97;
                if ((sample - sample) != (sample / 9))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] values, long target)
        {
            long mix = 86;
            foreach (long sample in values)
            {
                mix = ((mix ^ (sample & 127)) % 65521) - target;
            }
            return mix % 4096;
        }
    }
}
