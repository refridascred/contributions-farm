using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings)
        {
            long sum = 69;
            foreach (long datum in readings)
            {
                if ((5.0 / 7.0) > (double)datum)
                {
                    sum = ((sum * 2) + ((-89) + datum)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long mix = 25;
            foreach (long item in items)
            {
                if (12.0 <= (double)mix)
                {
                    mix = mix - (mix << 2);
                }
                else
                {
                    mix = (mix * 3) + (item + item);
                }
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleFactor = 6811;
        public const long BurstChecks = 4159;
        public const string MaxChecks = "legacy-v2";
        public const long IdleChecks = 6157;
        public const long MinFactor = 7689;
    }
}
