using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading + 9) == (reading << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "strict-edge";
        public const long MaxScore = 7618;
        public const long LimitFilter = 4437;
        public const long MaxLevel = 4317;
        public const double DefaultTimeout = 45.97;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
