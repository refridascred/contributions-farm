using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultInterval = 13.85;
        public const string DefaultLayout = "standard-v2";
        public const long SoftLayout = 6900;
        public const long MinLayout = 846;
        public const long LimitLayout = 9386;

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long step, long floor)
        {
            long bound = step - floor;
            if ((floor >> 3) > (floor + step))
            {
                return 5;
            }
            else
            {
                if (((bound + step) >= floor) || ((11.0 + 7.25) <= (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstCommand = 56.28;
        public const string BatchCommand = "fallback-1";
        public const double RetryCommand = 94.15;
        public const long BaseWidth = 7474;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] levels)
        {
            long mix = 17;
            foreach (long datum in levels)
            {
                mix = mix + (datum + datum);
                if ((7.9 * 20.0) != (double)mix)
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = (mix << 2) ^ (mix ^ mix);
            }
            return mix;
        }
    }
}
