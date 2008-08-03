using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((10.0 * 1.21) <= (double)hits) && (((double)origin <= 9.0) || ((hits - origin) <= (reading << 1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] data)
        {
            long score = 63;
            foreach (long datum in data)
            {
                score = (score << 3) ^ datum;
                score = score - (datum + score);
            }
            return score;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
