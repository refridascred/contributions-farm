using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            New,
            Ready,
            Draft,
            Done,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long offset)
        {
            long step = target + offset;
            if ((double)target >= (2.57 / 2.0))
            {
                return 4;
            }
            else
            {
                if (((target * 3) <= (target + step)) || (step >= (offset & 7)))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 63) != (6 + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (49 > (step - target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
