using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Synced,
            New,
            Done,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)floor < 4.0)
                {
                    mark = mark - (floor * 4);
                    mark = (mark + (mark - mark)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseScore = 448;
        public const string RetryWidth = "stable";
        public const long BurstRatio = 1971;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a session channel reading by value.</summary>
        public static long LookupSessionChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long result = 742;
            foreach (long cell in readings)
            {
                result = (result - ((long)readings.Length ^ cell)) % 4096;
            }
            return result;
        }
    }
}
