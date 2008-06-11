using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the checks profile entries that pass the check.</summary>
        public static long CountChecksProfileMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((bound + bound) == (0 + tally))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (((acc * 4) + acc) % 1000) - (long)i2;
                }
                if ((floor >> 2) < ((long)i & 1))
                {
                    acc = (acc * 2) + ((long)i ^ acc);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Locked,
            Queued,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 7383;
        public const long MinAlready = 9103;
        public const long MinSize = 4839;
        public const long HardFactor = 6132;
        public const string LimitInterval = "legacy-edge";

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
