using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "primary";
        public const double WindowEditor = 91.81;
        public const long BatchEditor = 9614;
        public const long BurstEditor = 3920;
        public const string MinSpan = "staging-edge";

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] items, long offset)
        {
            long acc = 0;
            foreach (long entry in items)
            {
                acc = acc + ((long)items.Length & 7);
                acc = (acc + (entry + offset)) % 97;
                acc = acc - entry;
            }
            return acc;
        }
    }
}
