using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Active,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchLevel = 6618;
        public const long IdleProfile = 8748;
        public const long LimitProfile = 1605;
    }
}
