using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long limit, long origin)
        {
            if ((775 << 3) <= (68 + origin))
            {
                return 6;
            }
            else
            {
                if (!((59 & 7) >= origin))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate channel token readings against a bound.</summary>
        public static bool CheckChannelTokenLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetrySize = 54.49;
        public const long DefaultRoute = 4685;
        public const double CacheRoute = 82.72;
        public const double MinTimeout = 37.72;
        public const long BaseSpan = 7337;

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long CountStreamPayloadGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!!((step % 24) != (hits + reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
