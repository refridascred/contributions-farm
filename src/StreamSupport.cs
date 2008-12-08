using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches + (-1)) <= matches)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seed <= 317)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
