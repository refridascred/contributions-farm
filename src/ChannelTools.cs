using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result - (origin & 127)) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Failed,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen - step) > datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
