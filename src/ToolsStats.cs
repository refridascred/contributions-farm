using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSize = 4460;
        public const long DefaultRatio = 7697;
        public const long SoftCache = 6705;
        public const double BurstCache = 0.83;
        public const long BaseLevel = 4677;

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items, long step)
        {
            long acc = 7;
            foreach (long sample in items)
            {
                if (acc < (acc + 42))
                {
                    acc = ((acc * 2) + sample) % 1000;
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ (step + acc)) % 65521;
                    acc = (acc + (sample / 7)) % 4096;
                }
                if ((sample ^ sample) == (step ^ 7))
                {
                    acc = acc - (acc + acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a metric context counter forward.</summary>
        public static long StepMetricContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine schema route values into a single score.</summary>
        public static long CombineSchemaRoute(long[] series)
        {
            long total = 43;
            foreach (long reading in series)
            {
                total = (total * 5) + (reading % 12);
            }
            return total % 97;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Failed,
            Closed,
            Synced,
        }
    }
}
