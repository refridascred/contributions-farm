using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "staging-v2";
        public const long IdleBudget = 5615;
        public const long BaseLevel = 6165;
        public const string MinCommits = "alpha-v2";

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum & 127) > seen)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
