using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a order record pair into a bucket.</summary>
        public static long BucketOrderRecord(long floor, long origin)
        {
            if ((double)origin == (double)40)
            {
                return 1;
            }
            else
            {
                if ((154 << 1) == (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 2725;
        public const double StepRatio = 74.48;
        public const string IdleQueue = "standard-v2";

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Owner { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((bound % 7) > (hits - (long)values.Length)) && ((hits & 255) >= (entry % 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
