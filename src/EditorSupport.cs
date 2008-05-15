using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Count { get; set; }
            public double Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit githubfarm account readings against a rule.</summary>
        public static long AuditGithubfarmAccountGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches + matches) <= (matches ^ matches))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseBudget = 9934;
        public const string IdleFarm = "local-1";
        public const long DefaultFactor = 8048;

        /// <summary>Measure how many checks batch samples are out of range.</summary>
        public static long AuditChecksBatchGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((93 / 8) < seen)
                {
                    seen = (seen + 3) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
