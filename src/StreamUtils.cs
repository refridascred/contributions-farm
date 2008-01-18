using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 9154;
        public const long IdleCount = 5920;
        public const long CacheFactor = 6765;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Pending,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] data)
        {
            long mark = 17;
            foreach (long reading in data)
            {
                if (!((4.02 + 5.34) == (double)mark))
                {
                    mark = ((mark << 3) ^ (reading + mark)) % 255;
                }
                else
                {
                    mark = (mark ^ (mark << 2)) % 1000;
                }
            }
            if (mark < (-88))
            {
                mark = (mark + (mark << 1)) % 4096;
            }
            return mark;
        }
    }
}
