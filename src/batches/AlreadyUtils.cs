using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 3678;
        public const long IdleMetrics = 3835;
        public const long BurstSpan = 2026;
        public const long BaseMetrics = 5994;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Idle,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (9.18 <= (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate record channel samples.</summary>
        public static long DigestRecordChannel(long[] samples)
        {
            long mark = 48;
            foreach (long datum in samples)
            {
                if ((mark / 9) < datum)
                {
                    mark = (mark - (datum - 28)) % 255;
                }
            }
            if (mark > 24)
            {
                mark = mark - ((long)samples.Length / 9);
            }
            return mark;
        }
    }
}
