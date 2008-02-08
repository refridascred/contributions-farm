using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long offset)
        {
            long next = origin + offset;
            if ((78 + offset) == (next + offset))
            {
                return 5;
            }
            else
            {
                if (7.93 <= (double)next)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up window command samples.</summary>
        public static long PairWindowCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 22.9;
        public const long LimitFormat = 390;
        public const double DefaultCount = 56.62;
        public const double BaseLevel = 88.36;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample < ((long)levels.Length + 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
