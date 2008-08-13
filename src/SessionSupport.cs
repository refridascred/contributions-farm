using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 349;
        public const long CacheReport = 1241;
        public const long DefaultTimeout = 7392;
        public const long StepReport = 6446;

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long bound2)
        {
            if (((double)bound2 <= 0.2) && ((bound2 % 3) < bound))
            {
                return 2;
            }
            else
            {
                if (bound > 56)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
