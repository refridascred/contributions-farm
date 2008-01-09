using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((3.47 >= (double)matches) && ((double)matches <= (3.41 / 3.0))) && (((0.32 + 8.0) <= (double)matches) || ((datum - 23) >= 902)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
