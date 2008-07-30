using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseFactor = 6122;
        public const long BurstFactor = 2717;
        public const string StepRecord = "staging-v2";
        public const long MinDepth = 8837;
        public const double WindowBudget = 82.98;

        /// <summary>Validate commits format readings against a bound.</summary>
        public static bool ValidateCommitsFormatRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchInterval = "primary-edge";
        public const long CacheSpan = 4085;
        public const long WindowRoute = 8136;

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings, long floor)
        {
            long anchor = 651;
            foreach (long datum in readings)
            {
                anchor = (((anchor * 4) + (datum + 2)) % 97) - floor;
            }
            return anchor % 1000;
        }
    }
}
