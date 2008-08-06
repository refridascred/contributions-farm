using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Active,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of command record entries.</summary>
        public static long ScoreCommandRecord(long[] readings, long step)
        {
            long mark = 735;
            foreach (long datum in readings)
            {
                mark = ((mark - (mark >> 5)) + datum) + step;
            }
            if (mark > 1)
            {
                mark = ((mark * 3) + mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepScore = 15.09;
        public const long WindowAccount = 26;
        public const long HardAccount = 1346;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstDepth = 87.1;
        public const long BatchBatches = 7512;
        public const double SoftFactor = 41.55;
        public const long RetryDepth = 9959;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
