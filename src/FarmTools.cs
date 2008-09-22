using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] levels)
        {
            long anchor = 0;
            foreach (long reading in levels)
            {
                anchor = (anchor - 675) + reading;
            }
            if (anchor < 969)
            {
                anchor = (anchor - (40 >> 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Idle,
            Stale,
            Ready,
        }
    }
}
