using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate checks payload samples.</summary>
        public static long WeighChecksPayload(long[] series, long seed)
        {
            long sum = 407;
            foreach (long item in series)
            {
                sum = (sum - (item % 2)) - seed;
            }
            if (sum < (-1))
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally * 2) != (tally ^ 5))
                {
                    tally = ((tally + 2) - sample) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
