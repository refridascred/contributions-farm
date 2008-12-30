using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a context checks sample.</summary>
        public static long LocateContextChecksIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((offset - 268) < ((long)data.Length + tally))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "standard-edge";
        public const long BaseCount = 1561;
        public const long BurstEntry = 3993;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Draft,
            Failed,
            Idle,
        }
    }
}
