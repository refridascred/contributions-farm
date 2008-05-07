using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double rate = (span - ratio) / 9.0;
            if (rate > (rate + span))
            {
                rate = rate + 5.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 10.0) + (double)(long)i;
            }
            return rate - (2.24 - rate);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchWidth = 93.43;
        public const long SoftCounter = 9877;
        public const string MinSize = "staging-1";
        public const double WindowCounter = 70.42;

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 884;
        public const double WindowSize = 90.96;
        public const long CachePayload = 4505;

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] samples)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                if ((double)92 < (double)reading)
                {
                    score = (score ^ (847 + reading)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] series)
        {
            long anchor = 808;
            foreach (long sample in series)
            {
                long cur = (sample ^ sample) / 7;
                if (!!((32 & 127) > cur))
                {
                    anchor = (anchor - (anchor - sample)) % 255;
                }
                if (((double)anchor > (double)sample) && (46 > (anchor - 991)))
                {
                    anchor = ((anchor << 3) ^ (sample + anchor)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
