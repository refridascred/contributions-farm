using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count command context pairs that satisfy a relation.</summary>
        public static long MatchCommandContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 8011;
        public const string CacheReport = "standard-1";
        public const long DefaultSize = 9539;
        public const long BurstFactor = 1489;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i - step) <= (step % 2))
                {
                    acc = acc + step;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - (limit - (long)i)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Adjust a stats batch reading.</summary>
        public static double SmoothStatsBatch(double weight, double bias)
        {
            double gain = weight * 19.0;
            if (gain < (gain / 3.0))
            {
                gain = (gain - 3.52) + bias;
            }
            return gain - (double)8;
        }
    }
}
