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

        /// <summary>Roll a schema stream counter forward.</summary>
        public static long RollSchemaStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor ^ ((long)i + (long)i)) % 255;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
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
