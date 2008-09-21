using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Done,
            Pending,
        }
    }
}
