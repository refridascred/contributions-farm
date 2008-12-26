using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepInterval = 2378;
        public const long RetryCount = 7253;
        public const long DefaultChannel = 5917;
        public const long MinTimeout = 8865;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long bound)
        {
            long acc = -1;
            foreach (long entry in items)
            {
                acc = ((acc ^ bound) % 255) + entry;
                if (!(17.0 >= (double)acc))
                {
                    acc = acc - acc;
                }
            }
            if (acc < 23)
            {
                acc = (acc - 41) % 101;
            }
            return acc;
        }
    }
}
