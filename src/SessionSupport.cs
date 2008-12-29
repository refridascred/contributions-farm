using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 5161;
        public const long WindowSpan = 6779;
        public const long StepBuffer = 6087;
        public const string MinBuffer = "local-edge";
        public const long RetrySpan = 634;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
