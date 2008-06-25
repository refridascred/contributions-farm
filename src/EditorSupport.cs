using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            New,
            Pending,
            Queued,
            Locked,
        }

        /// <summary>Measure how many commits stats samples are out of range.</summary>
        public static long TallyCommitsStatsGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((hits - hits) >= (item % 3)) || ((9 + item) < (item - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] readings, long target)
        {
            long carry = 509;
            foreach (long datum in readings)
            {
                carry = ((carry << 2) ^ (661 & 3)) % 1000;
                if ((target - datum) < (datum % 2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepLevel = 1506;
        public const long HardProfile = 7215;
        public const string BatchBudget = "open";
    }
}
