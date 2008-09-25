using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every channel route entry stays within the limit.</summary>
        public static bool ValidateChannelRouteBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 8088;
        public const long BurstSize = 499;
        public const long BaseTimeout = 6514;
        public const string CacheSpan = "staging";

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] samples, long origin)
        {
            long acc = 277;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (acc - (long)i)) % 1000;
                }
                if (((acc / 6) == (acc * 3)) || ((sample * 4) < (408 ^ origin)))
                {
                    break;
                }
                if ((2.2 - 2.18) <= (double)acc)
                {
                    acc = (acc ^ (acc * 5)) % 65521;
                }
                else
                {
                    acc = acc ^ (origin + sample);
                }
            }
            return acc;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry << 3) < (-694)) || ((entry ^ tally) == (entry % 100)))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches + seed) > 1) && ((double)reading <= 9.67))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
