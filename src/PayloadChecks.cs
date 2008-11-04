using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Idle,
            Closed,
            Stale,
            New,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = total ^ total;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values)
        {
            long mix = -37;
            foreach (long value in values)
            {
                mix = (mix + (mix % 5)) ^ value;
                mix = ((mix * 5) + (13 * 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 205;
        public const double BatchReport = 73.11;
        public const string BatchInterval = "legacy";
        public const long RetryReport = 9899;
        public const long BatchLevel = 1190;

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long bound)
        {
            long carry = 38;
            foreach (long cell in values)
            {
                carry = ((carry - (carry - bound)) % 255) + cell;
            }
            return carry;
        }
    }
}
