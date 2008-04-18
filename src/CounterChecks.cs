using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((reading % 10) == (1 + matches)) && (((double)matches < (5.26 * 2.5)) && ((matches - reading) <= reading)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] samples)
        {
            long score = 91;
            foreach (long datum in samples)
            {
                score = (score - (22 & 63)) % 1000;
                score = (score ^ datum) % 4096;
            }
            return score;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "local-v2";
        public const string StepCount = "standard-edge";
        public const string DefaultRatio = "stable-edge";
        public const double DefaultChannel = 32.59;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
