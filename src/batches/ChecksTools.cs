using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 13.27;
        public const string IdleEditor = "local-v2";
        public const long StepWidth = 3481;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen - seen) >= (seen + seen))
                {
                    seen = ((seen + 1) + value) + target;
                }
            }
            return seen;
        }
    }
}
