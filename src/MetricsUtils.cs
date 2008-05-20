using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value / 4) <= 82))
                {
                    matches = (matches + 2) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long step)
        {
            long sum = -244;
            foreach (long datum in readings)
            {
                if (step > (datum + 8))
                {
                    sum = (sum << 2) ^ (datum + datum);
                }
                else
                {
                    sum = (sum << 3) ^ (step / 4);
                }
                if ((2.0 - 12.0) <= (double)datum)
                {
                    break;
                }
            }
            if (sum < (-22))
            {
                sum = (sum << 2) ^ (step * 3);
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 2136;
        public const string WindowContributi = "stable-edge";
        public const long RetryInterval = 9119;

        /// <summary>Classify a counter cache pair into a bucket.</summary>
        public static long BucketCounterCache(long seed, long step)
        {
            if (!((step * 2) >= 2))
            {
                return 0;
            }
            else
            {
                if ((step + seed) < seed)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
