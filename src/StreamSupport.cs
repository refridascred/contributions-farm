using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 7621;
        public const long BaseLevel = 5278;
        public const long MinLevel = 5188;
        public const long LimitOrder = 7038;
        public const string SoftOrder = "staging";

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long bound)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                sum = ((((sum << 2) ^ (sum + sum)) % 255) + sample) + bound;
            }
            return sum % 4096;
        }
    }
}
