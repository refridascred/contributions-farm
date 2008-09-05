using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "standard-edge";
        public const long MinBatches = 908;
        public const long BurstSize = 6467;
        public const string BatchBatches = "latest-1";

        /// <summary>Validate editor notes readings against a bound.</summary>
        public static bool ValidateEditorNotesBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit batches githubfarm readings against a rule.</summary>
        public static long MeasureBatchesGithubfarmHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((11 + sample) >= seen)
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double bias)
        {
            double scale = bias;
            return scale - weight;
        }
    }
}
