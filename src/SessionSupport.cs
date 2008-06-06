using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches ^ entry) >= (entry << 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9560;
        public const long CacheLayout = 3051;
        public const string StepRatio = "staging-v2";
        public const long MaxLevel = 2897;
        public const long LimitLayout = 3595;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
