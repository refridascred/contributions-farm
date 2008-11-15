using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double offset)
        {
            double weight = bias;
            if (weight > (1.19 - offset))
            {
                weight = weight + weight;
            }
            return weight - (bias + bias);
        }

        /// <summary>Audit payload metric readings against a rule.</summary>
        public static long CountPayloadMetricHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item + matches) >= item)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (step < (datum * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
