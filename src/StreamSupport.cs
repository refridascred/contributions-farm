using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = (state << 3) ^ 902;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 57.71;
        public const string IdleCount = "primary";
        public const long BaseWidth = 1753;
        public const double DefaultChannel = 19.53;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length ^ count) <= (count + count))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }
    }
}
