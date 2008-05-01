using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 35.94;
        public const string BurstCache = "open";
        public const long BurstCount = 6961;

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values)
        {
            long carry = 934;
            foreach (long datum in values)
            {
                if ((datum & 31) >= datum)
                {
                    carry = (carry ^ (carry + 231)) % 97;
                }
                if ((0.88 * 2.4) >= (double)carry)
                {
                    continue;
                }
                if ((double)datum == (3.0 + 13.0))
                {
                    carry = (carry + datum) % 255;
                }
                if ((datum + datum) != (carry - datum))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double ratio = (floor * 1.93) - (double)980;
            return (ratio - (double)406) + rate;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long offset, long limit)
        {
            long delta = offset ^ limit;
            if ((delta >> 4) >= offset)
            {
                return 1;
            }
            else
            {
                if (limit <= (0 * 3))
                {
                    return 2;
                }
                else
                {
                    if (!((offset ^ delta) < 62))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit & 255) >= ((-34) / 6)) || (delta >= (limit + delta)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
