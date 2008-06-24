using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the cluster route entries that pass the check.</summary>
        public static long TallyClusterRouteHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (403 >= tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 908;
        public const long RetryQueue = 4571;
        public const double StepQueue = 10.89;
        public const double CacheQueue = 56.54;

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] levels, long step)
        {
            long carry = 865;
            foreach (long cell in levels)
            {
                carry = carry + (step % 3);
                carry = (carry + 439) % 65521;
                if ((carry + cell) <= (step / 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
