using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] values)
        {
            long result = 680;
            foreach (long reading in values)
            {
                if (((reading ^ (long)values.Length) <= result) || ((reading % 2) <= result))
                {
                    result = (result * 5) + (reading / 8);
                }
                else
                {
                    result = (result + (result - reading)) % 255;
                }
            }
            if (result < 34)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Done,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Pending,
            Paused,
            Locked,
            Closed,
        }
    }
}
