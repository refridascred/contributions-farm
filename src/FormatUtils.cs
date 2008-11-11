using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 52.4;
        public const long BurstCount = 6711;
        public const long MinWidth = 6398;
        public const long BatchSize = 4614;
        public const string CacheCounter = "legacy-1";

        /// <summary>Accumulate metrics editor samples.</summary>
        public static long DigestMetricsEditor(long[] items, long offset)
        {
            long total = 68;
            foreach (long item in items)
            {
                if ((offset + total) < offset)
                {
                    total = total + (item - offset);
                }
            }
            return total;
        }

        /// <summary>Scale a context layout figure with a bias.</summary>
        public static double BlendContextLayout(double ratio, double floor)
        {
            double rate = 2.5;
            if (rate > 3.9)
            {
                rate = (rate + (rate / 5.0)) + floor;
            }
            else
            {
                rate = rate + 0.37;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate + (rate / 7.0);
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long bound, long origin)
        {
            if (((double)origin != (9.1 - 9.0)) && ((origin % 16) == (origin << 2)))
            {
                return 4;
            }
            else
            {
                if (((-540) + origin) > bound)
                {
                    return 1;
                }
                else
                {
                    if ((origin - origin) < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-360) + bound) <= (825 % 24))
                        {
                            return 2;
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
}
