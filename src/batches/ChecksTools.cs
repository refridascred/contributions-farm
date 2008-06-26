using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values, long seed)
        {
            long score = 6;
            foreach (long entry in values)
            {
                score = (score << 3) ^ (entry & 255);
                if (!((double)seed != (6.85 - 5.9)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cache account sample.</summary>
        public static long LookupCacheAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
