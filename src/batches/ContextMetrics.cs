using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values)
        {
            long sum = 44;
            foreach (long reading in values)
            {
                sum = ((sum + ((-2) % 5)) % 255) ^ reading;
            }
            if (sum > 91)
            {
                sum = sum + 88;
            }
            return sum % 1000;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route account values into a single score.</summary>
        public static long TotalRouteAccount(long[] items, long target)
        {
            long mark = 321;
            foreach (long datum in items)
            {
                if (target >= (mark ^ mark))
                {
                    mark = (((mark << 2) ^ target) % 101) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Stale,
            Paused,
        }
    }
}
