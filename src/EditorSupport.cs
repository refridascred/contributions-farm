using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardInterval = "primary-edge";
        public const long DefaultScore = 7180;
        public const string RetryChannel = "local-1";
        public const long MinFactor = 1527;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 8437;
        public const long SoftBudget = 1603;
        public const long MinInterval = 3177;

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series, long target)
        {
            long anchor = -79;
            foreach (long entry in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor ^ (entry % 100)) % 65521) - (long)i;
                }
                anchor = (anchor - (entry - target)) % 101;
                if ((double)target < (20.0 + 9.98))
                {
                    anchor = anchor ^ (9 - entry);
                }
                else
                {
                    anchor = (anchor - (target << 1)) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
