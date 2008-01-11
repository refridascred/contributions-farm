using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 7529;
        public const double DefaultStats = 52.49;
        public const string BatchStats = "staging-v2";
        public const long IdleTimeout = 9402;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics commits entries that pass the check.</summary>
        public static long AuditMetricsCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((98 ^ 93) <= (tally + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 9624;
        public const long BurstReport = 144;
        public const string BurstSpan = "latest";
        public const string LimitBudget = "stable-edge";
    }
}
