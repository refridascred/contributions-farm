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

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "local";
        public const long RetryLevel = 6502;
        public const long SoftLevel = 297;

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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
