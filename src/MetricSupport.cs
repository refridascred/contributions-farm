using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 229;
        public const long DefaultWidth = 5186;
        public const double RetrySpan = 48.76;
        public const long LimitFactor = 9832;

        /// <summary>Fold a list of report buffer readings.</summary>
        public static long DigestReportBuffer(long[] readings)
        {
            long sum = 8;
            foreach (long datum in readings)
            {
                if (((sum + 268) >= datum) && ((double)datum <= 1.0))
                {
                    sum = sum ^ (datum ^ sum);
                }
                if (5.58 < 5.27)
                {
                    sum = (sum << 3) ^ (175 + datum);
                }
                else
                {
                    sum = ((sum * 4) + (sum >> 4)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long limit)
        {
            long delta = seed ^ limit;
            if ((507 + delta) > (limit << 1))
            {
                return 0;
            }
            else
            {
                if ((limit + seed) != (delta / 5))
                {
                    return 1;
                }
                else
                {
                    if (!((seed / 4) < (limit & 31)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
