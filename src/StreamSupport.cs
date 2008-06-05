using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 269;
        public const double MaxSize = 24.25;
        public const long DefaultSession = 291;
        public const string StepWidth = "latest";
        public const double BaseScore = 21.86;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Locked,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
