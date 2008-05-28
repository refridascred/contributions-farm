using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Pending,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Look up the position of a profile support sample.</summary>
        public static long LookupProfileSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order command samples are out of range.</summary>
        public static long CountOrderCommandHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (1.26 * 2.31))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchInterval = 2876;
        public const long CacheWidth = 6940;
        public const long DefaultBuffer = 1355;
        public const long IdleLevel = 3544;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] samples, long target)
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
    }
}
