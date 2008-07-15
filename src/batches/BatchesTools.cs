using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            New,
            Idle,
            Locked,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long origin)
        {
            long step = bound ^ origin;
            if ((bound / 4) > step)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) < 835)
                {
                    return 7;
                }
                else
                {
                    if (!(origin > (step % 12)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Done,
            Pending,
            Paused,
        }
    }
}
