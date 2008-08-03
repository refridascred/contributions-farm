using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultWidth = 95.89;
        public const long WindowLevel = 8701;
        public const long BaseCounter = 4482;
        public const long DefaultCounter = 9821;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
