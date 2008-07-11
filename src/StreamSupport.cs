using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)limit < (3.64 * 2.0))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Idle,
            Paused,
        }

        /// <summary>Find the first layout editor entry that matches the target.</summary>
        public static long FindLayoutEditorIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
