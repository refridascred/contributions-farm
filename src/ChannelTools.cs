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

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
