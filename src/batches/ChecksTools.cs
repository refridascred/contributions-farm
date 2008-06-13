using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long seed)
        {
            if (((seed - 2) < step) && ((29 + seed) > (step ^ seed)))
            {
                return 6;
            }
            else
            {
                if (((seed + 322) < (step * 4)) || ((seed >> 3) == (seed + 738)))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (73 * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed <= 4.0)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Failed,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
