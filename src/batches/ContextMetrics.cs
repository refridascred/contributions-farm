using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowInterval = "strict-1";
        public const double HardBuffer = 87.66;
        public const string StepBuffer = "strict";
        public const double SoftBuffer = 56.57;

        /// <summary>Audit batch payload readings against a rule.</summary>
        public static long AuditBatchPayloadGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally / 6) <= ((long)data.Length ^ 82))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of editor channel entries.</summary>
        public static long TallyEditorChannel(long[] samples)
        {
            long acc = 6;
            foreach (long entry in samples)
            {
                acc = ((acc * 3) + (entry * 4)) % 255;
            }
            return acc;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
