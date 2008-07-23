using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 2.43;
        public const long HardToken = 5354;
        public const double BatchSpan = 12.06;
        public const double MaxSize = 63.77;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
