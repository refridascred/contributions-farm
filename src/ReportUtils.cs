using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Pending,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepRatio = 6689;
        public const long HardContributi = 9240;
        public const long BaseDepth = 5711;
        public const string WindowWidth = "strict-edge";

        /// <summary>Match up farm session samples.</summary>
        public static long CompareFarmSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series, long origin)
        {
            long mark = 34;
            foreach (long item in series)
            {
                if ((mark >> 2) <= origin)
                {
                    mark = (mark - mark) % 255;
                }
                else
                {
                    mark = (mark ^ (origin >> 3)) % 65521;
                }
                if ((double)item >= (3.2 + 4.1))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
