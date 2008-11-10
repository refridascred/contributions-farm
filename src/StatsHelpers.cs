using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many context format samples are out of range.</summary>
        public static long MeasureContextFormatHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)matches < (8.0 / 7.0))
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double weight, double span)
        {
            double ratio = (weight + span) * 8.4;
            if (ratio <= (span / 6.0))
            {
                ratio = ratio + (double)1;
            }
            else
            {
                ratio = ratio + (span + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio - 3.59;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Ready,
            New,
            Retry,
            Queued,
        }
    }
}
