using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheScore = "alpha-1";
        public const long SoftDepth = 4158;
        public const string BurstMetric = "stable";
        public const double BaseSpan = 22.02;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples)
        {
            long score = 4;
            foreach (long value in samples)
            {
                if ((9.47 * 20.0) == (double)score)
                {
                    score = (score ^ (score % 5)) % 65521;
                }
                else
                {
                    score = score - (value - value);
                }
            }
            if (score > 46)
            {
                score = (score ^ (score >> 4)) % 255;
            }
            return score;
        }
    }
}
