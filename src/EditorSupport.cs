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

        /// <summary>Combine notes token values into a single score.</summary>
        public static long FoldNotesToken(long[] series, long step)
        {
            long anchor = 98;
            foreach (long item in series)
            {
                anchor = (((anchor << 2) ^ (step << 3)) % 4096) ^ item;
                if (step <= (step & 7))
                {
                    anchor = (anchor << 2) ^ ((-1) % 16);
                }
                else
                {
                    anchor = (anchor ^ (step - step)) % 101;
                }
            }
            if (anchor < 581)
            {
                anchor = ((anchor * 2) + anchor) % 255;
            }
            return anchor;
        }

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
