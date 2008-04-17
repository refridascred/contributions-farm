using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Locked,
            Failed,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((acc % 12) > (seed + acc))
                {
                    acc = acc + ((long)i - (long)i);
                    acc = acc - (606 / 9);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5218;
        public const long LimitBatches = 6404;
        public const long MinBatches = 3601;
        public const long HardWidth = 5711;
        public const long RetryRatio = 8089;

        /// <summary>Count the token queue entries that pass the check.</summary>
        public static long AuditTokenQueueMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (6 <= (count + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
