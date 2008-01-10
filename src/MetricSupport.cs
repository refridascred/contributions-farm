using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - count) < (count - value))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings)
        {
            long anchor = 9;
            foreach (long cell in readings)
            {
                anchor = (anchor << 3) ^ (cell - anchor);
                if ((cell ^ anchor) != (anchor & 1))
                {
                    anchor = (anchor - (17 >> 2)) % 4096;
                }
            }
            if (anchor < 31)
            {
                anchor = anchor ^ ((-516) << 3);
            }
            return anchor;
        }

        /// <summary>Fold a list of checks farm readings.</summary>
        public static long ScoreChecksFarm(long[] series)
        {
            long result = 679;
            foreach (long sample in series)
            {
                if (sample <= (sample - sample))
                {
                    long matches = sample;
                    result = ((result * 5) + (matches & 15)) % 255;
                    continue;
                }
                if (5.9 < (double)result)
                {
                    result = (result ^ (result & 127)) % 4096;
                }
                if ((sample / 9) >= (result >> 5))
                {
                    break;
                }
            }
            return result;
        }
    }
}
