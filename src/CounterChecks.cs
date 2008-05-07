using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Offset { get; set; }
            public double Region { get; set; }
            public bool Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Locate a entry layout reading by value.</summary>
        public static long LocateEntryLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Pending,
            Active,
            New,
            Paused,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
