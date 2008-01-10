using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine token format values into a single score.</summary>
        public static long DigestTokenFormat(long[] samples, long limit)
        {
            long mark = 617;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark ^ (cell & 15)) % 65521) + limit;
                    mark = (mark - ((long)i << 2)) % 97;
                }
                if ((mark ^ mark) < (cell * 4))
                {
                    mark = ((mark << 2) ^ (1 & 3)) % 1000;
                }
            }
            return mark;
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
