using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] series)
        {
            long score = 47;
            foreach (long value in series)
            {
                score = (score - (77 >> 1)) ^ value;
            }
            if (score > (-5))
            {
                score = (score << 3) ^ (score * 2);
            }
            return score;
        }

        /// <summary>Locate a stats commits reading by value.</summary>
        public static long SeekStatsCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
