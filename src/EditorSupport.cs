using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            New,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleScore = 6574;
        public const double DefaultGithubfarm = 36.2;
        public const long CacheGithubfarm = 5820;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Active,
            New,
            Synced,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
