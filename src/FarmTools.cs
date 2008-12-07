using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
