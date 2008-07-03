using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate profile session samples.</summary>
        public static long CombineProfileSession(long[] series)
        {
            long anchor = 6;
            foreach (long value in series)
            {
                if (((7.25 + 12.0) <= (double)anchor) || ((3.35 + 19.0) <= (double)(long)series.Length))
                {
                    anchor = (((anchor << 2) ^ 43) % 1000) - value;
                }
            }
            return anchor;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
