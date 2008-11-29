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

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = (total ^ (origin * 3)) % 65521;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
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
